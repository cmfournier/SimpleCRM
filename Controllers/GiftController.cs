﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCRM.Models;
using SimpleCRM.ViewModels;
using SimpleCRM.Data;

namespace SimpleCRM.Controllers
{
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

        /*public IActionResult Add()
        {
            AddGiftViewModel addGiftViewModel = new AddGiftViewModel();
            return View(addGiftViewModel);
        }*/

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
    }
}