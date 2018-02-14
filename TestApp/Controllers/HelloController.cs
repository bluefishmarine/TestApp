using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApp.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {  
            string html = "<form method='post'>" + 
                "<input type='text' name ='name' />" + 
                "<input type='submit' value='Greet Me' />" + 
                "</form>";

            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "world")
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name), "text/html");
        }

        //Handle requests to /Hello/name (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name), "text/html");
        }


        //Hello/Goodbye
        //Alter route to this controller to be /Hello/Aloha
        [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye World!");
        }

    }
}
