﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitAndSweet.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult Create()
        {
            return View();
        }
    }
}