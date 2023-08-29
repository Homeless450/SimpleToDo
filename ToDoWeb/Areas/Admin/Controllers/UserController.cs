using Microsoft.AspNetCore.Mvc;

namespace ToDoWeb.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
