﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Paycompute.Entity;
using Paycompute.Models;
using Paycompute.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Controllers
{
    [Authorize]
    public class EmployeeController:Controller
    {

        
        private readonly IEmployeeService _employeeService;
        private readonly HostingEnvironment _hostingEnvironment;
        public EmployeeController(IEmployeeService employeeService,HostingEnvironment hostingEnvironment)
        {
            _employeeService = employeeService;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index(int? pageNumber)
        {

            var employees = _employeeService.GetAll().Select(employee => new EmployeeIndexViewModel
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                ImageURL = employee.ImageURL,
                FirstName = employee.FirstName,
                FullName = employee.FullName,
                City=employee.City,
                Gender = employee.Gender,
                Designation = employee.Designation,
                DateJoined = employee.DateJoined

            }).ToList();
            int pageSize = 4;
            return View(EmployeeListPagination< EmployeeIndexViewModel >.Create(employees,pageNumber??1,pageSize) );
        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = new EmployeeCreateViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Create(EmployeeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee
                {

                    Id = model.Id,
                    EmployeeNo = model.EmployeeNo,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    FullName = model.FullName,
                    MiddleName = model.MiddleName,
                    Gender = model.Gender,
                    Dob = model.Dob,
                    DateJoined = model.DateJoined,
                    Designation = model.Designation,
                    Email = model.Email,
                    NationalInsurance = model.NationalInsurance,
                    PaymentMethod = model.PaymentMethod,
                    StudentLoan = model.StudentLoan,
                    UnionMember = model.UnionMember,
                    Address = model.Address,
                    City = model.City,
                    Phone = model.Phone,
                    PostCode = model.PostCode

                };

                if(model.ImageURL!=null && model.ImageURL.Length>0)
                {
                    var uploadDir = @"images/employee";
                    var fileName = Path.GetFileNameWithoutExtension(model.ImageURL.FileName);
                    var extension = Path.GetExtension(model.ImageURL.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                     fileName = DateTime.UtcNow.ToString("yyyyssfff") + fileName + extension;

                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                  await model.ImageURL.CopyToAsync(new FileStream(path, FileMode.Create));
                    employee.ImageURL = "/" + uploadDir + "/" + fileName;
                }
                await _employeeService.CreateAsync(employee);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var employee = _employeeService.getById(id);
            if(employee == null)
            {
                return NotFound();
            }

            var model = new EmployeeEditViewModel()
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                FirstName =employee.FirstName,
                LastName = employee.LastName,
                
                MiddleName = employee.MiddleName,
                Gender = employee.Gender,
                Dob = employee.Dob,
                DateJoined= employee.DateJoined,
                
                Designation = employee.Designation,
                Email = employee.Email,
                NationalInsurance = employee.NationalInsurance,
                PaymentMethod = employee.PaymentMethod,
                StudentLoan = employee.StudentLoan,
                UnionMember = employee.UnionMember,
                Address = employee.Address,
                City = employee.City,
                Phone = employee.Phone,
                PostCode = employee.PostCode

            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(EmployeeEditViewModel model){

            if (ModelState.IsValid)
            {
                var employee = _employeeService.getById(model.Id);

                if(employee == null)
                {
                    return NotFound();
                }

                employee.EmployeeNo = model.EmployeeNo;
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.MiddleName = model.MiddleName;
                employee.Address = model.Address;
                employee.City = model.City;
                employee.Designation = model.Designation;
                employee.Dob = model.Dob;
                employee.Email = model.Email;
                employee.Gender = model.Gender;
                employee.NationalInsurance = model.NationalInsurance;
                employee.PaymentMethod = model.PaymentMethod;
                employee.Phone = model.Phone;
                employee.StudentLoan = model.StudentLoan;
                employee.UnionMember = model.UnionMember;
                employee.PostCode = model.PostCode;
                employee.DateJoined = model.DateJoined;
                if(model.ImageURL!= null && model.ImageURL.Length>0)
                {
                    var uploadDir = @"images/employee";
                    var fileName = Path.GetFileNameWithoutExtension(model.ImageURL.FileName);
                    var extension = Path.GetExtension(model.ImageURL.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yyyyssfff") + fileName + extension;

                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                   await model.ImageURL.CopyToAsync(new FileStream(path, FileMode.Create));
                    employee.ImageURL = "/" + uploadDir + "/" + fileName;

                }
               await  _employeeService.UpdateAsync(employee);

                return RedirectToAction(nameof(Index));
            }
            
            return View();

        }


        public IActionResult Detail(int id)
        {
           var employee = _employeeService.getById(id);

            if(employee == null)
            {
                return NotFound();
            }

            EmployeeDetailViewModel model = new EmployeeDetailViewModel
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                FullName = employee.FullName,
                Gender = employee.Gender,
                Dob = employee.Dob,
                DateJoined = employee.DateJoined,

                Designation = employee.Designation,
                Email = employee.Email,
                NationalInsurance = employee.NationalInsurance,
                PaymentMethod = employee.PaymentMethod,
                StudentLoan = employee.StudentLoan,
                UnionMember = employee.UnionMember,
                Address = employee.Address,
                City = employee.City,
                Phone = employee.Phone,
                PostCode = employee.PostCode,
                ImageURL= employee.ImageURL
            };

            return View(model);
        }



        public IActionResult Delete(int id)
        {

            var employee = _employeeService.getById(id);

            if (employee == null)
            {
                return NotFound();
            }

            var model = new EmployeeDeleteViewModel()
            {
                Id = employee.Id,
                FullName = employee.FullName
            };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Delete(EmployeeDeleteViewModel model)
        {

            await _employeeService.Delete(model.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
