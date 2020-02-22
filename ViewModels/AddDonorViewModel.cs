using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SimpleCRM.Models;

namespace SimpleCRM.ViewModels
{
    public class AddDonorViewModel
    {
        public int DDonor { get; set; }
        [Required(ErrorMessage = "Donor name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }
        [Required(ErrorMessage = "You must enter a valid ZIP Code")]
        [Display(Name="ZIP Code")]
        public string Zip { get; set; }
    }
}
