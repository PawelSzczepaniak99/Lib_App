using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp.Models;

namespace LibApp.Controllers
{
    public class Bookscontroller : Controller
    {
        //GET /Books/Random 

        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "Eglish Dictionary" };

            return View(firstBook);
        }
    }
}
