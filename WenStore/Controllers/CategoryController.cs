using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WenStore.Data;
using WenStore.Models.Store;

namespace WenStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GetAllCategories
        [HttpGet("GetAllCategories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            var result = await _context.Categories.ToListAsync();
            
            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }

        // GET: api/GetCategoryWithProducts/5
        [HttpGet("GetCategoryWithProducts/{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategoryWithProducts(long id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            var products = await _context.Products.Where(p => p.CategoryId == id).ToListAsync();
            var result = new CategoryDto(category, products);

            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }

        // GET: api/GetCategory/5
        [HttpGet("GetCategory/{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategory(long id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var products = new List<Product>();
            var result = new CategoryDto(category, products);

            return result;
        }

        [HttpPatch("UpdateCategory/{id}")]
        public async Task<IActionResult> PutCategory(long id, CategoryMin min)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            category.CategoryName = min.CategoryName;
            _context.Entry(category).State = EntityState.Modified;
            
            await _context.SaveChangesAsync();

            return new ObjectResult(category) { StatusCode = StatusCodes.Status200OK };
        }

        [HttpPost("CreateCategory")]
        public async Task<ActionResult<Category>> PostCategory(CategoryMin category)
        {
            _context.Categories.Add(new Category(category));
            await _context.SaveChangesAsync();

            return new ObjectResult(category) { StatusCode = StatusCodes.Status201Created, };
        }

        // DELETE: api/Category/5
        [HttpDelete("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(long id)
        {
            // if (_context.Categories == null)
            // {
            //     return NotFound();
            // }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}