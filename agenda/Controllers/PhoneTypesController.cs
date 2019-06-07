using agenda.Data;
using agenda.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace agenda.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PhoneTypesController : Controller
  {
    private readonly DataContext context;

    public PhoneTypesController(DataContext context)
    {
      this.context = context;
    }
    [HttpGet("/api/phonetypes")]
    public IEnumerable<PhoneType> Get()
    {
      return context.Set<PhoneType>().ToList();
    }
  }
}
