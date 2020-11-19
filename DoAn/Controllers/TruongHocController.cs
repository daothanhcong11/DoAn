using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class TruongHocController : Controller
    {
        public IActionResult TruongHoc()
        {
            return View();
        }
        public IActionResult TruongHocTaoMoi()
        {
            return View();
        }
    }
}
