using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRM.ViewModels
{
    public class AddGiftViewModel
    {
        //Validation needs to check database to verify that Donor ID exists([Required] won't work)
        //[Required(ErrorMessage="You must enter a valid Donor ID")]
        [Display(Name ="Donor ID")]
        public int TDonor { get; set; }
        public string TYear { get; set; }
        public string TMonth { get; set; }
        public string TDay { get; set; }

        //Validation needs to check that amount is greater than zero
        //[Required(ErrorMessage = "Please enter a gift amount")]
        [Display(Name = "Gift Amount")]
        public float TAmount { get; set; }

        //Validation needs to check database to verify that Campaign Code exists
        //[Required(ErrorMessage = "You must enter a valid campaign code for the gift")]
        [Display(Name = "Campaign Code")]
        public string TCampaign { get; set; }

        public readonly string currentYear = DateTime.Now.Year.ToString();
        public readonly string currentMonth = DateTime.Now.Month.ToString();
        public readonly string currentDay = DateTime.Now.Day.ToString();

    }
}
