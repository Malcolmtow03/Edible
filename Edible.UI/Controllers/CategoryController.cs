using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Edible.Core.Contracts;
using Edible.Core.Models;

namespace Edible.UI.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<ProductCategory> repository;
        public CategoryController(IRepository<ProductCategory> categoryContext)
        {
            this.repository = repository;
        }

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}