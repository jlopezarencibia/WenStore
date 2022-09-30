using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WenStore.Data;
using WenStore.Models.Store.Product;

namespace WenStore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
      _context = context;
    }

    // GET: api/products
    [HttpGet("GetAllProducts")]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
      var result = await _context.Products.ToListAsync();

      return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
    }

    [HttpGet("GetProductWithData/{id}")]
    public async Task<ActionResult<ProductDto>> GetProductWithData(long id)
    {
      var product = await _context.Products.FindAsync(id);
      if (product == null)
      {
        return NotFound();
      }

      var category = await _context.Categories.FindAsync(product.CategoryId);
      var result = new ProductDto(product, category!);
      return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
    }

    [HttpGet("GetProduct/{id}")]
    public async Task<ActionResult<Product>> GetProduct(long id)
    {
      var product = await _context.Products.FindAsync(id);
      if (product == null)
      {
        return NotFound();
      }

      return new ObjectResult(product) { StatusCode = StatusCodes.Status200OK };
    }

    // PUT: api/product/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPatch("SetDealToProduct/{id}")]
    public async Task<IActionResult> SetDeal(long id, ProductMin min)
    {
      var product = await _context.Products.FindAsync(id);
      if (product == null)
      {
        return NotFound();
      }

      product.DealPrice = min.DealPrice;
      _context.Entry(product).State = EntityState.Modified;

      await _context.SaveChangesAsync();

      return new ObjectResult(product) { StatusCode = StatusCodes.Status200OK };
    }

    [HttpPost("CreateProduct")]
    public async Task<ActionResult<Product>> CreateProduct(ProductMin product)
    {
      var result = _context.Products.Add(new Product(product));
      _context.Entry(result.Entity).State = EntityState.Added;
      await _context.SaveChangesAsync();

      return new ObjectResult(result.Entity) { StatusCode = StatusCodes.Status201Created };
    }

    [HttpDelete("DeleteProduct/{id}")]
    public async Task<IActionResult> DeleteProduct(long id)
    {
      // if (_context.Products == null)
      // {
      //   return NotFound();
      // }

      var product = await _context.Products.FindAsync(id);
      if (product == null)
      {
        return NotFound();
      }

      product.Stock = 0;
      _context.Entry(product).State = EntityState.Deleted;
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool ProductExists(long id)
    {
      return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}