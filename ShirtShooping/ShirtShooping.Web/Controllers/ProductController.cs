using Microsoft.AspNetCore.Mvc;
using ShirtShooping.Web.Models;
using ShirtShooping.Web.Services.IServices;

namespace ShirtShooping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProductIndex()
        {
            var products = await _productService.FindAllProducts();
            return View(products);
        }
        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var products = await _productService.CreateProduct(model);
                if (Response != null) return RedirectToAction(nameof(ProductIndex));
            }
            return View(model);
        }
    }
}
