using Microsoft.AspNetCore.Mvc;

namespace HelloMvc
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
        
        [HttpGet("/about")]
        public IActionResult About(){
            var useragent = Request.Headers["User-Agent"];
            return Content(useragent + "\r\nabout by linezerop");
        }
    }
}