using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace agenda.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TestController : ControllerBase
  {
    [HttpGet("/api/values")]
    public IEnumerable<string> Get()
    {
      return new string[] { "a", "b", "c" };
    }
  }
}
