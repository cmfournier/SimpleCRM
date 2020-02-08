using System;
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
    public class DonorController : Controller
    {
        private readonly ApplicationDbContext context;
        public DonorController(ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddDonorViewModel addDonorViewModel = new AddDonorViewModel();
            return View(addDonorViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddDonorViewModel addDonorViewModel)
        {
            if (ModelState.IsValid)
            {
                Donor newDonor = new Donor()
                {
                    Name = addDonorViewModel.Name,
                    Address = addDonorViewModel.Address,
                    City = addDonorViewModel.City,
                    State = addDonorViewModel.State,
                    Zip = addDonorViewModel.Zip
                };
                context.Donors.Add(newDonor);
                context.SaveChanges();
                return Redirect("/Donor");
            }
            return View();
        }
    }
}


       



