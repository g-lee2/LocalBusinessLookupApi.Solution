using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessApi.Models;

namespace BusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly BusinessApiContext _db;

    public BusinessesController(BusinessApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get()
    {
      return await _db.Businesses.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      Business business = await _db.Businesses.FindAsync(id);

      if (business == null)
      {
        return NotFound();
      }

      return business;
    }
  }
}
