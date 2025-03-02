﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Misison12GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Misison12GroupProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext contextInfo { get; set; }

        public HomeController(ApplicationContext data)
        {
            contextInfo = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var AppointmentsList = contextInfo.appointments
                .Where(a => a.Taken == false)
                .ToList();
            return View(AppointmentsList);
        }


        
        public IActionResult Appointments()
        {
            return View();
        }

        public IActionResult AddAppointment()
        {
            return View();
        }

    }
}

