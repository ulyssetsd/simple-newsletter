﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using simple_newsletter.Models;

namespace simple_newsletter.Controllers
{
    public class NewsLetterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Subscribe")]
        public IActionResult Subscribe()
        {
            ViewData["Message"] = "Your succesfully subscribe to the newsletter !";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}