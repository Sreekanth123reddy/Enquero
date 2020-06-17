using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidley.Models;

namespace vidley.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Index
        public ActionResult Index()
        {
            VidleyEntities db = new VidleyEntities();
            List<Movy> movies = db.Movies.ToList();
            return View(movies);
        }
    }
}