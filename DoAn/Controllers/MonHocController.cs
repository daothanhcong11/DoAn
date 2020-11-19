using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class MonHocController : Controller
    {
        public IActionResult MonHoc()
        {
            return View();
        }
        public IActionResult MonHocTaoMoi()
        {
            return View();
        }
        
    }
}
