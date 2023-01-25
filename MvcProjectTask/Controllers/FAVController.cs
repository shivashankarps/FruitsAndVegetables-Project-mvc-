using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProjectTask.Models;
using System.Data.Entity;

namespace MvcProjectTask.Controllers
{
    public class FAVController : Controller
    {

        private readonly ApplicationDbContext _context = null;

        public FAVController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: FAV
        public ActionResult Index()
        {
            var Shop = _context.shop.ToList();
            return View(Shop);

        }

        public ActionResult Update()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Update(FruitsAndVegetables shop)
        {
            if (ModelState.IsValid)
            {
               // var categories = _context.Categories.ToList();
                _context.shop.Add(shop);
                _context.SaveChanges();
                // return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var fruits = _context.shop.FirstOrDefault(p => p.Id == id);
            if (fruits != null)
            {
                var Shops = _context.shop.ToList();
                ViewBag.shop = Shops;
                return View(fruits);
            }
            return HttpNotFound("Product Id doesn't exists");
        }
        [HttpPost]
        public ActionResult Edit(FruitsAndVegetables fruits)
        {
            if (fruits != null)
            {
                var fruitsAndVegetables = _context.shop.Find(fruits.Id);
                if (fruitsAndVegetables != null)
                {
                    fruitsAndVegetables.Quantity = fruits.Quantity;
                    fruitsAndVegetables.Discount = fruits.Discount;
                    fruitsAndVegetables.Price = fruits.Price;
                    fruitsAndVegetables.TotalPrice = fruits.TotalPrice;
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            var Shops = _context.shop.ToList();
            ViewBag.shop = Shops;
            return View(fruits);
        }
    }
}