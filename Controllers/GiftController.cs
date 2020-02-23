using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCRM.Models;
using SimpleCRM.ViewModels;
using SimpleCRM.Data;

namespace SimpleCRM.Controllers
{
    [Authorize]
    public class GiftController : Controller
    {
        private readonly ApplicationDbContext context;
        public GiftController (ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }
        public IActionResult Index()
        {
            AddGiftViewModel addGiftViewModel = new AddGiftViewModel();
            return View(addGiftViewModel);
        }


        [HttpPost]
        public IActionResult Index(AddGiftViewModel addGiftViewModel)
        {
            

            if (ModelState.IsValid)
            {
                Transactions newTransaction = new Transactions()
                {
                    TDonor = addGiftViewModel.TDonor,
                    TYear = addGiftViewModel.currentYear,
                    TMonth = addGiftViewModel.currentMonth,
                    TDay = addGiftViewModel.currentDay,
                    TAmount = addGiftViewModel.TAmount,
                    TCampaign = addGiftViewModel.TCampaign
                };
                context.Transactions.Add(newTransaction);
                context.SaveChanges();
                return Redirect("/Gift");
            }
            return View();
        }
        /*[HttpPost]
        public ActionResult CheckIfCampaign(string TCampaign)
        {
            try
            {
                return Json(!CampaignExists(TCampaign));
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
        private bool CampaignExists(string TCampaign)
            List<Campaign> Campaigns = context.Campaigns.ToList();
            => */
        /*[HttpPost]
        public JsonResult IsCampaign(string TCampaign)
        {
            return Json(DoesCampaignExist(TCampaign));
        }
        public bool DoesCampaignExist(string CampaignCode)
        {
            List<Campaign> Campaigns = context.Campaigns.ToList();//new List<Campaign>();
            var ExistingCampaigns = (from c in Campaigns
                                     where c.CampaignCode == CampaignCode()
                                     select new { CampaignCode }).FirstOrDefault();
            bool status;
            if (ExistingCampaigns != null)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }*/

        /*[AcceptVerbs("GET", "POST")]
        public IActionResult VerifyDonorID(int donorid)
        {
            if (SimpleCRM.Data.)
            //if (!Donor.VerifyDonorID(donorid))
                
            {
                return Json
            }
        }*/
    }
}