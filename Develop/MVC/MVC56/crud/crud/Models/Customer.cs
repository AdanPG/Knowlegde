using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }




        //[DataType(DataType.Date)] para que la fecha solo guarde fecha sin hora
    }
}