﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    using static WebConstants;
    public class UsersController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route(Routing.AdminCreateUser)]
        public IActionResult Create()
        {
            return View();
        }
    }
}