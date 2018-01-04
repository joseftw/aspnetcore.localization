using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _stringLocalizer;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer ?? throw new ArgumentNullException(nameof(stringLocalizer));
        }

        public IActionResult Index()
        {
            var localizedHeading = this._stringLocalizer["Heading"];
            return View("~/Views/Home/Index.cshtml", localizedHeading.Value);
        }
    }
}
