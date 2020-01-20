using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCRM.Controllers
{
    public class GiftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}