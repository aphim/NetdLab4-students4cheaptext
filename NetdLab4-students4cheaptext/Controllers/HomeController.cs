using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetdLab4_students4cheaptext.Models;

namespace NetdLab4_students4cheaptext.Controllers
{
    public class HomeController : Controller
    {
        //create a list of textbook objects
        List<textbook> textBookList = new List<textbook>();

        //when the index page is referenced
        public IActionResult Index()
        {
            return View();
        }

        //when the appraise page is referenced
        [HttpGet]
        public IActionResult Appraise()
        {
            return View();


        }

        //when the appraised page is referenced in post
        [HttpPost]
        public IActionResult Appraise(textbook model)
        {
            //if data entered in appraise page is valid
            if (ModelState.IsValid)
            {
                ViewData["titleText"] = "Your textbook: " + model.textTitle + ", version:";
                ViewData["valueText"] = model.textVersion + " was appraised at: $" + model.calcValue(model.textPrice, model.textCondition);

                return View("Appraised", model);
            }
            //if invalid data was entered in the appraise page
            else
            {
                return View("Bad");
            }
        }
    }
}
