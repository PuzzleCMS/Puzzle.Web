using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puzzle.Web.Areas.PuzzleCMS.Controllers
{
    public class Manage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
