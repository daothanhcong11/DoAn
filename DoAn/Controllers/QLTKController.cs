﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class QLTKController : Controller
    {
        public IActionResult TaoTkAd()
        {
            return View();
        }
        public IActionResult SuaTkAd()
        {
            return View();
        }
    }
}
