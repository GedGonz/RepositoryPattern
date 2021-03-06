﻿using Aplicacion.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPatterns.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonaServicio personaServicio;
        public HomeController(IPersonaServicio personaServicio)
        {
            this.personaServicio = personaServicio;
        }
        public ActionResult Index()
        {
            var Data = personaServicio.ListAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}