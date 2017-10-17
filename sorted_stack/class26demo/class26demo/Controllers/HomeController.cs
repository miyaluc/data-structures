using class26demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class26demo.Controllers
{
    public class HomeController : Controller
    {
        //we created private context variable in order to use it in dependency injection
        private class26demoContext _context;

        //constructor for HomeController - a DBContext is required
        public HomeController(class26demoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //calling to the CMS table in the database and getting content for ID 1
            var result = _context.CMS.Where(c => c.ID == 1);

            return View(result.ToList());
        }
    }
}
