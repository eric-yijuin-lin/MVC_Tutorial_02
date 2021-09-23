using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Tutorial_02.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Tutorial_02.Controllers
{
    public class FormInput
    {
        public string TextInput { get; set; }
        public int NumberInput { get; set; }
        public DateTime DateTimeInput { get; set; }
        public string RadioInput { get; set; }
        public string checkInput1 { get; set; }
        public string checkInput2 { get; set; }
        public string checkInput3 { get; set; }
        public string selectInput { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult HtmlWithBootstrap()
        {
            return View();
        }
        public IActionResult HtmlWithGlobalCss()
        {
            return View();
        }
        public IActionResult HtmlWithStyleAttribute()
        {
            return View();
        }

        public IActionResult FormDemo()
        {
            return View();
        }
        public IActionResult FormDemoWithRazor()
        {
            return View();
        }
        public IActionResult FormDemoWithRazorBootstrap()
        {
            return View();
        }

        [HttpPost]
        public string SubmitForm(FormInput input)
        {
            return input.checkInput1;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
