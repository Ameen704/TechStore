using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;
using TechStore.Models.ViewModels;

namespace TechStore.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(string? searchTerm, int? categoryId)
        {
            var query = _context.Products.Include(p => p.Category).AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(p => p.Name.Contains(searchTerm));
                ViewBag.SearchTerm = searchTerm;
            }

            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
                ViewBag.CategoryId = categoryId.Value;
            }

            ViewBag.Categories = await _context.Categories
                .Where(c => c.IsActive)
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .ToListAsync();

            var products = await query.OrderByDescending(p => p.CreatedAt).ToListAsync();
            return View(products);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product is null) return NotFound();
            return View(product);
        }

        public async Task<IActionResult> Create()
        {
            var vm = new ProductViewModel
            {
                Categories = await GetCategories()
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Categories = await GetCategories();
                return View(vm);
            }

            var product = new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Price = vm.Price,
                CategoryId = vm.CategoryId,
                IsActive = vm.IsActive
            };

            if (vm.ImageFile != null)
            {
                product.ImageUrl = await SaveImage(vm.ImageFile);
            }

            _context.Add(product);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Product created successfully";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null) return NotFound();

            var vm = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId,
                IsActive = product.IsActive,
                Categories = await GetCategories()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductViewModel vm)
        {
            if (id != vm.Id) return NotFound();

            if (!ModelState.IsValid)
            {
                vm.Categories = await GetCategories();
                return View(vm);
            }

            var product = await _context.Products.FindAsync(id);
            if (product is null) return NotFound();

            product.Name = vm.Name;
            product.Description = vm.Description;
            product.Price = vm.Price;
            product.CategoryId = vm.CategoryId;
            product.IsActive = vm.IsActive;
            product.UpdatedAt = DateTime.Now;

            if (vm.ImageFile != null)
            {
                if (!string.IsNullOrEmpty(product.ImageUrl))
                    DeleteImage(product.ImageUrl);

                product.ImageUrl = await SaveImage(vm.ImageFile);
            }

            _context.Update(product);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Product updated successfully";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (product is null) return NotFound();
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                if (!string.IsNullOrEmpty(product.ImageUrl))
                    DeleteImage(product.ImageUrl);

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Product deleted successfully";
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<List<SelectListItem>> GetCategories()
        {
            return await _context.Categories
                .Where(c => c.IsActive)
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .ToListAsync();
        }

        private async Task<string> SaveImage(IFormFile file)
        {
            var folder = Path.Combine(_env.WebRootPath, "images", "products");
            Directory.CreateDirectory(folder);
            var unique = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
            var path = Path.Combine(folder, unique);
            using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            return $"/images/products/{unique}";
        }

        private void DeleteImage(string url)
        {
            var path = Path.Combine(_env.WebRootPath, url.TrimStart('/'));
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
        }
    }
}
