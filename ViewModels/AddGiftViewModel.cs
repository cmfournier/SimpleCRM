using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRM.ViewModels
{
    public class AddGiftViewModel
    {
        public int TDonor { get; set; }
        public string TYear { get; set; }
        public string TMonth { get; set; }
        public string TDay { get; set; }
        public float TAmount { get; set; }
        public string TCampaign { get; set; }

        public readonly string currentYear = DateTime.Now.Year.ToString();
        public readonly string currentMonth = DateTime.Now.Month.ToString();
        public readonly string currentDay = DateTime.Now.Day.ToString();

    }
}
