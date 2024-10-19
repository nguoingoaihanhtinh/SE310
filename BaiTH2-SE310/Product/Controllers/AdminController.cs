using Microsoft.AspNetCore.Mvc;
using Product.Data;
using System.Linq;

namespace Product.Controllers
{
    public class AdminController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public AdminController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public IActionResult Index()
        {
            // Fetch necessary data to be displayed in the dashboard here
            var foodCount = _dbHelper.GetAllFoods().Count();
            // Assuming User operations are added to the DatabaseHelper
            var userCount = _dbHelper.getAllUser().Count();

            var foods = _dbHelper.GetAllFoods();
            var prices = foods.Select(f => f.Price).ToArray();
            var foodNames = foods.Select(f => f.Name).ToArray();
            var users = _dbHelper.getAllUser();

            ViewBag.FoodCount = foodCount;
            ViewBag.Prices = prices; // Pass prices to the view
            ViewBag.FoodNames = foodNames;
            ViewBag.UserCount = userCount;
            ViewBag.Users = users;// Uncomment when users are added

            return View();
        }
    }
}
