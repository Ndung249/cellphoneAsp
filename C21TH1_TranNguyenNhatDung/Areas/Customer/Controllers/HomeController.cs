using C21TH1_TranNguyenNhatDung.Data;
using C21TH1_TranNguyenNhatDung.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace C21TH1_TranNguyenNhatDung.Areas.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _db)
        {
            _logger = logger;
            db = _db;

        }

        public IActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageIndex;
            pageIndex = page == null ? 1 : (int)page;

            var lstProduct = db.Products.ToList();
            //int.pageCount = (int)Math.Ceiling((double)lstProduct.Count / pageSize);
            int pageCount = lstProduct.Count / pageSize + (lstProduct.Count % pageSize > 0 ? 1 : 0);

            ViewBag.pageCount = pageCount;
            ViewBag.pageIndex = pageIndex;

            return View(lstProduct.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList());

        }

        [HttpGet]
        public IActionResult Detail(int Id)
        {
            var getProduct = db.Products.Find(Id);
            var idCategory = getProduct.CategoryId;
            List<Product> products = db.Products.Where(x => x.CategoryId == idCategory).ToList();
            ViewBag.products = products;
            return View(getProduct);
        }



    }
}
