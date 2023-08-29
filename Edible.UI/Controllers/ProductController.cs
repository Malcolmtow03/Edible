using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Edible.Core.Contracts;
using Edible.Core.Models;
using Edible.Core.ViewModels;


namespace Edible.UI.Controllers
{
    public class ProductController: Controller
    {
        IRepository<Product> context;
    }
}