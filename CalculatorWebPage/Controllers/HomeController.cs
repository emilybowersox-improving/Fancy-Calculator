using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CalculatorWebPage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorCore;

namespace CalculatorWebPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
     

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

/*        public IActionResult Index()
        {
            var userSavedNumber = HttpContext.Session.Get<CalcInput>("SavedNumber");
            var vm = new CalculatorViewModel();
            vm.LastNumber = userSavedNumber;

            return View(vm);
        }*/


        public IActionResult Index()
        {
            var userSavedNumber = HttpContext.Session.GetString("EvaluateNumber");
            var calculator = new Calculator();
            var vm = new CalculatorViewModel();

            if (userSavedNumber != null)
            {
                EvaluationResult _calculatedNumber = new EvaluationResult();
                _calculatedNumber = calculator.Evaluate(userSavedNumber);
                vm.UserResult = _calculatedNumber;
            }
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(string userNumber)
        {
            HttpContext.Session.SetString("EvaluateNumber", userNumber);

            return RedirectToAction("Index");
        }


        public IActionResult History()
        {
            var calculator = new Calculator();
            var vm = new CalculatorViewModel();


            return View();
        }




/*        [HttpPost] 
        public IActionResult Index(CalcInput userNumber)
        {
            HttpContext.Session.Set("SavedNumber", userNumber);
      
            return RedirectToAction("Index");
        }*/

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
