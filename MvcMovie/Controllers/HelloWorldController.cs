using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        //
        // GET /HelloWorld/Welcome
        public string Welcome(int id)
        {
            return HtmlEncoder.Default.Encode($"Hello {id} go to vault fast");
        }

    }
}
