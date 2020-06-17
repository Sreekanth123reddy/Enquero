﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBApproach.Models;

namespace EFDBApproach.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands/Index
        public ActionResult Index()
        {
            EFDBFirstdatabaseEntities db = new EFDBFirstdatabaseEntities();
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
    }
}