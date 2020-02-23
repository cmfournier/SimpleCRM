using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCRM.Data;
using SimpleCRM.Models;
using SimpleCRM.ViewModels;

namespace SimpleCRM.Controllers
{
    [Authorize]
    public class CampaignController : Controller
    {
        private readonly ApplicationDbContext context;
        public CampaignController (ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }
        public IActionResult Index()
        {
            List<Campaign> campaigns = context.Campaigns.ToList();
            return View(campaigns);
        }

        public IActionResult Add()
        {
            AddCampaignViewModel addCampaignViewModel = new AddCampaignViewModel();
            return View(addCampaignViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddCampaignViewModel addCampaignViewModel)
        {
            if (ModelState.IsValid)
            {
                Campaign newCampaign = new Campaign()
                {
                    ID = addCampaignViewModel.ID,
                    CampaignCode = addCampaignViewModel.CampaignCode,
                    CampaignDescription = addCampaignViewModel.CampaignDescription,
                    CampaignMonth = addCampaignViewModel.CampaignMonth,
                    CampaignYear = addCampaignViewModel.CampaignYear

                };
                context.Campaigns.Add(newCampaign);
                context.SaveChanges();
                return Redirect("/Campaign");
            }
            return View(addCampaignViewModel);
        }

        public IActionResult Search ()
        {
            return View();
        }

        public async Task<IActionResult> Search(string campaignCode, string searchString)
        {
            IQueryable<string> campaignCodeQuery = from m in context.Campaigns
                                                   orderby m.CampaignCode
                                                   select m.CampaignCode;
            var campaigns = from c in context.Campaigns
                            select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                campaigns = campaigns.Where(s => s.CampaignDescription.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(campaignCode))
            {
                campaigns = campaigns.Where(x => x.CampaignCode == campaignCode);
            }
            var searchCampaignsViewModel = new SearchCampaignsViewModel
            {
                CampaignCode = await campaignCodeQuery.Distinct().ToListAsync()),
            Description = await campaigns.ToListAsync()
            };
            return View(await campaigns.ToListAsync());

        }

    }
