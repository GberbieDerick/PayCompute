using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Paycompute.Entity;
using Paycompute.Models;
using Paycompute.Services;
using RotativaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Paycompute.Controllers
{
    [Authorize(Roles="Admin,Manager")]
    public class PayController:Controller
    {
        private readonly IPayComputationService _payComputationService;

        public readonly IEmployeeService _employeeService;
        private readonly ITaxService taxService;
        private readonly INationalInsuranceContributionService _nationalInsuranceContributionService;
        private decimal overtimeEarn;
        private decimal contractualEarnings;
        private decimal totalEarnings;
        private decimal tax;
        private decimal slc;
        private decimal unionFee;
        private decimal nic;
        private decimal totalDeductions;

        public PayController(IPayComputationService payComputationService,IEmployeeService employeeService,ITaxService taxService,INationalInsuranceContributionService nationalInsuranceContributionService)
        {
            _payComputationService = payComputationService;
            _employeeService = employeeService;
            this.taxService = taxService;
            _nationalInsuranceContributionService = nationalInsuranceContributionService;
        }

        public IActionResult Index()
        {

            var payRecords = _payComputationService.GetAll().Select(pay => new PaymentRecordIndexViewModel
            {
                Id=pay.Id,
                EmployeeId = pay.EmployeeId,
                FullName=pay.FullName,
                PayDate=pay.PayDate,
                PayMonth=pay.PayMonth,
                TaxYearId = pay.TaxYearId,
                Year=_payComputationService.GetTaxYearById(pay.TaxYearId).YearOfTax,
                TotalDeductions=pay.TotalDeduction,
                TotalEarnings=pay.TotalEarnings,
                NetPayment = pay.NetPayment,
                Employee =pay.Employee

            });
            return View(payRecords);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewBag.employees = _employeeService.GetAllEmployeesForPayroll();


            ViewBag.taxYears = _payComputationService.GetAllTaxYear();
            var model = new PaymentRecordCreateViewModel();
            return View(model);
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(PaymentRecordCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var payRecord = new PaymentRecord()
                {
                    Id = model.Id,
                    EmployeeId = model.EmployeeId,
                    FullName = _employeeService.getById(model.EmployeeId).FullName,
                    NiNo = _employeeService.getById(model.EmployeeId).NationalInsurance,
                    PayDate = model.PayDate,
                    PayMonth = model.PayMonth,
                    TaxYearId = model.TaxYearId,
                    TaxCode = model.TaxCode,
                    HourlyRate = model.HourlyRate,
                    HoursWorked = model.HoursWorked,
                    ContractualHours = model.ContractualHours,
                    ContractualEarnings = contractualEarnings = _payComputationService.ContratualEarnings(model.HoursWorked, model.ContractualHours, model.HourlyRate),
                    OvertimeHours = _payComputationService.OvertimeHours(model.HoursWorked, model.ContractualHours),
                    OvertimeEarnings = overtimeEarn = _payComputationService.OverTimeEarnings(_payComputationService.OvertimeRate(model.HourlyRate), _payComputationService.OvertimeHours(model.HoursWorked, model.ContractualHours)),
                   
                    TotalEarnings = totalEarnings =_payComputationService.TotalEarnings(overtimeEarn, contractualEarnings),
                    Tax = tax=taxService.taxAmount(totalEarnings),
                    UnionFee =unionFee= _employeeService.UnionFee(model.EmployeeId),
                    SLC =slc =  _employeeService.studentLoanRepaymentAmount(model.EmployeeId , totalEarnings),
                    NIC = nic =_nationalInsuranceContributionService.NIContribution(totalEarnings),
                    TotalDeduction = totalDeductions= _payComputationService.TotalDeductions(tax,slc,unionFee,nic),
                    NetPayment = _payComputationService.NetPay(totalEarnings,totalDeductions)


                };
                await _payComputationService.CreateAsync(payRecord);

                return RedirectToAction(nameof(Index));

                
            }
            ViewBag.employees = _employeeService.GetAllEmployeesForPayroll();


            ViewBag.taxYears = _payComputationService.GetAllTaxYear();
            return View();
        }

        public IActionResult Detail(int id)
        {

            var paymentRecord = _payComputationService.GetById(id);

            if(paymentRecord == null)
            {
                return NotFound();
            }

            var model = new PaymentRecordDetailViewModel()
            {
             Id=paymentRecord.Id,
             EmployeeId = paymentRecord.EmployeeId,
             FullName = paymentRecord.FullName,
             NiNo = paymentRecord.NiNo,
             PayDate = paymentRecord.PayDate,
             PayMonth = paymentRecord.PayMonth,
             TaxYearId = paymentRecord.TaxYearId,
             Year = _payComputationService.GetTaxYearById(paymentRecord.TaxYearId).YearOfTax,
             TaxCode = paymentRecord.TaxCode,
             HourlyRate = paymentRecord.HourlyRate,
             HoursWorked = paymentRecord.HoursWorked,
             ContractualHours = paymentRecord.ContractualHours,
             ContractualEarnings = paymentRecord.ContractualEarnings,
             OvertimeHours = paymentRecord.OvertimeHours,
             OvertimeEarnings = paymentRecord.OvertimeEarnings,
             OvertimeRate = _payComputationService.OvertimeRate(paymentRecord.HourlyRate),
             Tax= paymentRecord.Tax,
             NIC = paymentRecord.NIC,
             UnionFee= paymentRecord.UnionFee,
             SLC=paymentRecord.SLC,
             TotalEarnings = paymentRecord.TotalEarnings,
             TotalDeduction=paymentRecord.TotalDeduction,
             NetPayment =paymentRecord.NetPayment,
             TaxYear = paymentRecord.TaxYear



            };
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Payslip(int id)
        {

            var paymentRecord = _payComputationService.GetById(id);

            if (paymentRecord == null)
            {
                return NotFound();
            }

            var model = new PaymentRecordDetailViewModel()
            {
                Id = paymentRecord.Id,
                EmployeeId = paymentRecord.EmployeeId,
                FullName = paymentRecord.FullName,
                NiNo = paymentRecord.NiNo,
                PayDate = paymentRecord.PayDate,
                PayMonth = paymentRecord.PayMonth,
                TaxYearId = paymentRecord.TaxYearId,
                Year = _payComputationService.GetTaxYearById(paymentRecord.TaxYearId).YearOfTax,
                TaxCode = paymentRecord.TaxCode,
                HourlyRate = paymentRecord.HourlyRate,
                HoursWorked = paymentRecord.HoursWorked,
                ContractualHours = paymentRecord.ContractualHours,
                ContractualEarnings = paymentRecord.ContractualEarnings,
                OvertimeHours = paymentRecord.OvertimeHours,
                OvertimeEarnings = paymentRecord.OvertimeEarnings,
                OvertimeRate = _payComputationService.OvertimeRate(paymentRecord.HourlyRate),
                Tax = paymentRecord.Tax,
                NIC = paymentRecord.NIC,
                UnionFee = paymentRecord.UnionFee,
                SLC = paymentRecord.SLC,
                TotalEarnings = paymentRecord.TotalEarnings,
                TotalDeduction = paymentRecord.TotalDeduction,
                NetPayment = paymentRecord.NetPayment,
                TaxYear = paymentRecord.TaxYear



            };
            return View(model);
        }

        public IActionResult GeneratePayslipPdf(int id)
        {
            var paymentRecord = _payComputationService.GetById(id);
            var Slug = Regex.Replace(paymentRecord.FullName, "[/w]", "_");
            var payslip = new ActionAsPdf("Payslip", new { id }) {
            
                
            FileName =Slug + DateTime.Now.ToString("yyyyMMddHHmmssfff")+ ".pdf"
            }
            ;
            return payslip;
        }


    }
}
