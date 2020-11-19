using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class GiaoVienController : Controller
    {
        public IActionResult GiaoVien()
        {
            return View();
        }
        public IActionResult TaoMoiGiaoVien()
        {
            return View();
        }
    }
}
