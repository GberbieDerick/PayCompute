using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class PaymentRecordCreateViewModel
    {
        public int Id { get; set; }
        
        [Display(Name ="Full Name")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        public string NiNo { get; set; }

        [DataType(DataType.Date), Display(Name = "Pay Date")]
        public DateTime PayDate { get; set; } = DateTime.UtcNow;
        [Display(Name = "Pay Month")]
        public string PayMonth { get; set; } = DateTime.Today.Month.ToString();
        

        public int TaxYearId { get; set; }
        public TaxYear TaxYear { get; set; }

        public string TaxCode { get; set; } = "1250L";
        
        [Display(Name ="Hourly Rate ")]

        public decimal HourlyRate { get; set; }

        [Display(Name = "Hours Worked ")]
        public decimal HoursWorked { get; set; }

        [Display(Name = "Contract Hours ")]
        public decimal ContractualHours { get; set; } = 144m;

        [Display(Name = "Overtime Hours ")]
        public decimal OvertimeHours { get; set; }

        [Display(Name = "Contractual Earnings ")]
        public decimal ContractualEarnings { get; set; } 

        [Display(Name = "Overtime Earnings")]
        public decimal OvertimeEarnings { get; set; }

        [Display(Name = "Tax")]
        public decimal Tax { get; set; }

        [Display(Name = "NIC")]
        public decimal NIC { get; set; }
        

        public decimal? UnionFee { get; set; }
        

        public Nullable<decimal> SLC { get; set; }
        

        public decimal TotalEarnings { get; set; }
        

        public decimal TotalDeduction { get; set; }
        
        public decimal NetPayment { get; set; }


    }
}
