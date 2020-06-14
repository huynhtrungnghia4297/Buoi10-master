using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buoi10.Models;
using Buoi10.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static Buoi10.Services.Interfaces.IDemo;

namespace Buoi10.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LayDanhMuc()
        {
            var dm = new DanhMuc
            {
                TenDanhMuc = "Điện thoại",
                SanPham = new string[] { "LG", "Sony", "Samsung", "Iphone" }
            };
            return PartialView("_DanhMuc", dm);
        }
        public IActionResult Demo()
        {
            return View();
        }
        private ITransientService _sv1;
        private ITransientService _sv2;
        private IScopedService _sv3;
        private IScopedService _sv4;
        private ISingletonService _sv5;
        private ISingletonService _sv6;
        public DemoController(ITransientService sv1, ITransientService sv2, IScopedService sv3, IScopedService sv4, ISingletonService sv5, ISingletonService sv6)
        {
            _sv1 = sv1;
            _sv2 = sv2;
            _sv3 = sv3;
            _sv4 = sv4;
            _sv5 = sv5;
            _sv6 = sv6;
        }
        public IActionResult DemoTransient()
        {
            ViewBag.Service1 = _sv1.GetID(); 
            ViewBag.Service2 = _sv2.GetID(); 
            ViewBag.Service3 = _sv3.GetID(); 
            ViewBag.Service4 = _sv4.GetID(); 
            ViewBag.Service5 = _sv5.GetID(); 
            ViewBag.Service6 = _sv6.GetID(); 
            return View() ;
        }
    }
}