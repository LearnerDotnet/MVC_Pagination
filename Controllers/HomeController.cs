using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(int? page)
        {
            var records = Enumerable.Range(1, 150).Select(x => "Record " + x);
            var pagination = new Pagination(records.Count(), page);
            var viewModel = new IndexViewModel { Items = records.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize), Pagination = pagination };
            return View(viewModel);
        }
    }
}
