using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace DropdownMVC.Models
{
    public class EmployeDetail
    {
        public  int ID { get;set; }

        [Required(ErrorMessage = "Name is mandary")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is mandary")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is mandary")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Select The Gender mandary")]
        public bool Gender { get; set; }

        public int StateID { get; set; }

        [NotMapped]
        public string StateName { get; set; }
        public int CityID { get; set; }

        [NotMapped]
        public string CityName { get; set; }
        public int DepartmentID { get; set; }

        [NotMapped]
        public string DepartmentName { get; set; }

    }
}