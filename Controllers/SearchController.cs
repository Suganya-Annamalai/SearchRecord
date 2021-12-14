using SearchRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchRecord.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            Decthirteen_OneEntities dbContext = new Decthirteen_OneEntities();
            return View(dbContext.Employees.ToList());
           // return View();
        }
        [HttpPost]
        public ActionResult Index(DateTime From, DateTime To)
        {
            Decthirteen_OneEntities dbContext = new Decthirteen_OneEntities();
            return View(dbContext.Usp_Empsearch(From, To));



        }
    }
}