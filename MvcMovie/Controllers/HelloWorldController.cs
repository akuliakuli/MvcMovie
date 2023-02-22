using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET /HelloWorld/
        public IActionResult Index(string name,int id)
        {
            ViewData["user"] = name;
            ViewData["userId"] = id;
            return View();
        }
        //
        // GET /HelloWorld/Welcome
        public IActionResult Welcome(int id)
        {
            return View();
        }

    }
}
