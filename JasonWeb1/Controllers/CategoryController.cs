using JasonWeb1.Data;
using JasonWeb1.Models;
using Microsoft.AspNetCore.Mvc;

namespace JasonWeb1.Controllers
{
    public class CategoryController : Controller
    {
        //retrivie category rows(data)
        private readonly ApplicationDbContext _dbCategory;
        public CategoryController(ApplicationDbContext dbCategory)
        {
            _dbCategory = dbCategory;
        }
        public IActionResult Index()
        {
            List<Category> objectCategoryList = _dbCategory.Categories.ToList();
            return View(objectCategoryList);
        }
    }
}
