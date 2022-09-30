using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WenStore.Data;
using WenStore.Models.Store;

namespace WenStore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AmazonProductController : ControllerBase
  {
    private readonly ApplicationDbContext _context;

    public AmazonProductController(ApplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet("GetAllAmazonProducts")]
    public async Task<ActionResult<IEnumerable<AmazonProduct>>> GetAmazonProducts()
    {
      var result = await _context.AmazonProducts.ToListAsync();

      return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
    }

    [HttpGet("GetAmazonProduct/{id}")]
    public async Task<ActionResult<AmazonProduct>> GetAmazonProduct(long id)
    {
      var amazonProduct = await _context.AmazonProducts.FindAsync(id);
      if (amazonProduct == null)
      {
        return NotFound();
      }

      return new ObjectResult(amazonProduct) { StatusCode = StatusCodes.Status200OK };
    }

    [HttpPatch("UpdateAmazonProduct/{id}")]
    public async Task<IActionResult> UpdateAmazonProduct(long id, AmazonProductMin min)
    {
      var amazonProduct = await _context.AmazonProducts.FindAsync(id);
      if (amazonProduct == null)
      {
        return NotFound();
      }

      amazonProduct.Name = min.Name;
      amazonProduct.Deal = min.Deal;
      amazonProduct.Description = min.Description;
      amazonProduct.Url = min.Url;
      // amazonProduct.IsDeleted = min.IsDeleted;
      amazonProduct.ImageRelativePath = min.ImageRelativePath;
      _context.Entry(amazonProduct).State = EntityState.Modified;

      await _context.SaveChangesAsync();

      return new ObjectResult(amazonProduct) { StatusCode = StatusCodes.Status200OK };
    }

    [HttpPost("CreateAmazonProduct")]
    public async Task<ActionResult<AmazonProduct>> PostAmazonProduct(AmazonProductMin min)
    {
      var result = await _context.AmazonProducts.AddAsync(
        new AmazonProduct(min)
      );

      await _context.SaveChangesAsync();

      return new ObjectResult(result) { StatusCode = StatusCodes.Status201Created };
    }

    [HttpDelete("DeleteAmazonProduct/{id}")]
    public async Task<IActionResult> DeleteAmazonProduct(long id)
    {
      // if (_context.AmazonProducts == null)
      // {
      //   return NotFound();
      // }

      var amazonProduct = await _context.AmazonProducts.FindAsync(id);
      if (amazonProduct == null)
      {
        return NotFound();
      }

      amazonProduct.IsDeleted = true;
      await _context.SaveChangesAsync();

      return NoContent();
    }
  }
}