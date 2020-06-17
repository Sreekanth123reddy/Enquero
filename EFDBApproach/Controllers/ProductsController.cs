using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBApproach.Models;

namespace EFDBApproach.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products/index
        public ActionResult Index(string search="")
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            // List<Product> products = db.Products.Where(temp=>temp.CategoryId==1 && temp.Price>75000).ToList();
            List<Product> products = db.Products.Where(temp => temp.ProductName.Contains(search)).ToList();
            ViewBag.search = search;
            return View(products);
        }
        //GET: Products/details

        public ActionResult Details(long id)
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            Product p = db.Products.Where(temp => temp.ProductId == id).FirstOrDefault();
            return View(p);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(long id)
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductId == id).FirstOrDefault();
            return View(existingProduct);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductId == p.ProductId).FirstOrDefault();
            existingProduct.ProductName = p.ProductName;
            existingProduct.Price = p.Price;
            existingProduct.DateOfPurchase = p.DateOfPurchase;
            existingProduct.AvailabilityStatus = p.AvailabilityStatus;
            existingProduct.CategoryId = p.CategoryId;
            existingProduct.BrandId = p.BrandId;
            existingProduct.Active = p.Active;
            db.SaveChanges();
            return RedirectToAction("Index", "Products");
        }
        public ActionResult Delete(long id)
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductId == id).FirstOrDefault();
            return View(existingProduct);
        }
        [HttpPost]
        public ActionResult Delete(long id,Product p)
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductId == id).FirstOrDefault();
            db.Products.Remove(existingProduct);
            db.SaveChanges();
            return RedirectToAction("index", "Products");
        }
    }
}