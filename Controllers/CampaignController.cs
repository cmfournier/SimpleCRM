using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCRM.Data;
using SimpleCRM.Models;

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
            return View();
        }

        //public IActionResult Add()
        //{

        //}
    }
}