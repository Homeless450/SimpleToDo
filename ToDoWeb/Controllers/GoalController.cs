using DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ToDoWeb.Controllers
{
    public class GoalController : Controller
    {
        private readonly ILogger<GoalController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public GoalController(ILogger<GoalController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {

            IEnumerable<Goal> goalsList = _unitOfWork.Goal.GetAll();
            return View(goalsList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Goal obj)
        {
            _unitOfWork.Goal.Add(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int? id)
        {
            if (id == 0 || id == null) return NotFound();

            Goal? goalFromDb = _unitOfWork.Goal.Get(c => c.Id == id);
            return View(goalFromDb);
        }

        [HttpPost]
        public IActionResult Update(Goal goal)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Goal.Update(goal);
                _unitOfWork.Save();
                TempData["success"] = "Goal edited successfully";
                return RedirectToAction("Index", "Home");
            }
            return View(goal);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Goal? goal = _unitOfWork.Goal.Get(c => c.Id == id);
            if (goal == null) return NotFound();

            return View(goal);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Goal? goal = _unitOfWork.Goal.Get(c => c.Id == id);
            if (goal == null)
            {
                return NotFound();
            }
            _unitOfWork.Goal.Remove(goal);
            _unitOfWork.Save();
            TempData["success"] = "Goal deleted successfully";
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}