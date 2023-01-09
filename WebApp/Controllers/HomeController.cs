using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IStringLocalizer<HomeController> _stringLocalizer;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            //ViewBag.Message = _stringLocalizer[name: "welcome"];
            return View();
        }
        //[HttpPost]
        //public IActionResult SetLangugage(string culture, string returnUrl)
        //{
        //    Response.Cookies.Append(
        //        CookieRequestCultureProvider.DefaultCookieName,
        //        CookieRequestCultureProvider.MakeCookieValue(requestCulture: new RequestCulture(culture)),
        //        options: new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(years: 1) }
        //        );
        //    return LocalRedirect(returnUrl);
        //}
        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}