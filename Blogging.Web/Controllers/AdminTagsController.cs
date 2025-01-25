using Microsoft.AspNetCore.Mvc;

namespace Blogging.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
