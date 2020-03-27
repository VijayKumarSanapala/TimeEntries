using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeEntriesEmployees.Models.DisplayClasses
{
    public class TimeEntriesViewModelDisplayClasses
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "First Name required")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use alphabets only please")]
        [StringLength(32, ErrorMessage = "Enter minimum 3 characters and maximum 50 characters ", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use alphabets only please")]
        [StringLength(32, ErrorMessage = "Enter minimum 3 characters and maximum 50 characters ", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email Format is wrong")]
        [StringLength(50, ErrorMessage = "Less than 50 characters")]
        [Display(Name = "Email Id ")]
        public string EmailAddress { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date is required ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public Nullable<System.DateTime> Date { get; set; }

        [Required(ErrorMessage = "Please Select Task")]
        public string Task { get; set; }

        [Required(ErrorMessage = "Enter Hours Worked")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter only digits")]
        //[StringLength(12, ErrorMessage = "Hours should be 1 digit atleast", MinimumLength = 1)]
        public Nullable<decimal> HoursWorked { get; set; }
        public string Comment { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}