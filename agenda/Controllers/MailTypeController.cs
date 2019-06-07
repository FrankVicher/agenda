using agenda.Data;
using agenda.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace agenda.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MailTypeController : Controller
  {
    private readonly DataContext context;

    public MailTypeController(DataContext context)
    {
      this.context = context;
    }
    [HttpGet("/api/mailtypes")]
    public IEnumerable<MailType> Get()
    {
      return context.Set<MailType>().ToList();
    }
  }
}
