using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBApproach.Models;

namespace EFDBApproach.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories/Index
        public ActionResult Index()
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            List<category> categories = db.categories.ToList();


            return View(categories);
        }
    }
}