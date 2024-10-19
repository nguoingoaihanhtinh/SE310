using Microsoft.AspNetCore.Mvc;
using Product.Data;
using Product.Models;

namespace Product.Controllers
{
    public class FoodController : Controller
    {
        private string connectionString = "Server=localhost;Database=food_db;User ID=root;Password=123456;";
        private readonly DatabaseHelper dbHelper;

        public FoodController()
        {
            dbHelper = new DatabaseHelper(connectionString); // Ensure you're passing the connection string
        }

        public IActionResult Index()
        {
            var foods = dbHelper.GetAllFoods();
            return View(foods);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Food food)
        {
            if (ModelState.IsValid)
            {
                dbHelper.AddFood(food);
                return RedirectToAction("Index");
            }
            return View(food);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var food = dbHelper.GetFoodById(id);
            if (food == null)
            {
                return NotFound();
            }
            return View(food); // Create an Edit.cshtml view for this
        }


        [HttpPost]
        public IActionResult Edit(Food food)
        {
            if (ModelState.IsValid)
            {
                dbHelper.UpdateFood(food);
                return RedirectToAction("Index");
            }
            return View(food);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            dbHelper.DeleteFood(id); // Implement this method to delete food from the database
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var food = dbHelper.GetFoodById(id);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }
    }
}
