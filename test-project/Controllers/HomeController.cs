using Microsoft.AspNetCore.Mvc;
using test_project.Models;
using test_project.Db.Models;
using test_project.Db.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace test_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productsStorage;
        private readonly ICategoriesRepository categoriesStorage;

        public HomeController(IProductsRepository productsStorage, ICategoriesRepository categoriesStorage)
        {
            this.productsStorage = productsStorage;
            this.categoriesStorage = categoriesStorage;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            // Загрузка списка категорий для отображения в выпадающем списке
            var categories = categoriesStorage.GetAll();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productDb = new Product
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    CategoryId = product.CategoryViewModel.Id 
                };

                productsStorage.Add(productDb);
                return RedirectToAction("Products");
            }
            var categories = categoriesStorage.GetAll();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View(product);
        }

        public IActionResult Products()
        {
            var products = productsStorage.GetAll();
            var productViewModels = new List<ProductViewModel>();

            foreach (var p in products)
            {
                var productViewModel = new ProductViewModel
                {
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    CategoryViewModel = new CategoryViewModel
                    {
                        Id = p.Id,
                        Name = categoriesStorage.TryGetById(p.CategoryId).Name
                    }
                };

                productViewModels.Add(productViewModel);
            }
            var categories = categoriesStorage.GetAll();
            ViewBag.Categories = categories.ToDictionary(c => c.Id, c => c.Name);
            return View(productViewModels);
        }

        public IActionResult Categories()
        {
			var categories = categoriesStorage.GetAll();
			var categoryViewModels = new List<CategoryViewModel>();
			foreach (var c in categories)
			{
				var categoryViewModel = new CategoryViewModel
				{
					Id = c.Id,
					Name = c.Name
				};
				categoryViewModels.Add(categoryViewModel);
			}
			return View(categoryViewModels);

		}

        public IActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel category)
        {
            Category categoryDb = new Category
            {
                Name = category.Name
            };
            categoriesStorage.Add(categoryDb);
            return View("Index");
        }
    }
}
