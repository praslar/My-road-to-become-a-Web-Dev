﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
namespace DLU.Areas.Admin.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: Admin/AD_TrangChu
        public ActionResult Index()
        {
           
            return View();
        }
    }
}