using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TP2.Models;
using TP2.Models.Data;

namespace TP2.Controllers
{
    public class HomeController : Controller
    {

        private TPDbContext _baseDonnees { get; set; }
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ILogger<HomeController> _logger;


        public HomeController(TPDbContext donnees, IStringLocalizer<HomeController> localizer, ILogger<HomeController> logger)
        {
            _baseDonnees = donnees;
            _localizer = localizer;
            _logger = logger;

        }

        public void OnGet()
        {
            _logger.LogInformation("About page visited at {DT}" ,
                DateTime.UtcNow.ToLongTimeString());
        }
        [Route("")]
        [Route("home/index")]
        [Route("index")]

        public IActionResult Index()
        {
            //ViewData["titre"] = "Acceuil";
            return View(_baseDonnees.Parents.ToList());
        }

        public IActionResult Privacy()
        {
            ViewBag.Title = _localizer["PrivacyTitle"];
            return View();
        }
        public IActionResult Dashboard()
        {

            return View();
        }
        public IActionResult Financial()
        {

            return View();
        }
        public IActionResult LeaderObjective()
        {

            return View();
        }
        public IActionResult Employes()
        {
            return View();

        }

        public IActionResult Consulter(int id)
        {


            //ViewData["titre"] = "Acceuil";
            var parentRecherche = _baseDonnees.Parents.Where(p => p.Id == id).Select(x=>x).SingleOrDefault();
                
            if (parentRecherche == null)
            {
                return View("NonTrouvé", "La liste de film n'a pas été trouvé!");
            }
            else
            {
                return View(parentRecherche);
            }
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            var cookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));
            var name = CookieRequestCultureProvider.DefaultCookieName;

            Response.Cookies.Append(name, cookie, new CookieOptions
            {
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddYears(1),
            });

            return LocalRedirect(returnUrl);
        }
    }
}
