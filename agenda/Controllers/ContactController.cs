using agenda.Data;
using agenda.Data.Entities;
using agenda.Data.Repositories;
using agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agenda.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ContactController : ControllerBase
  {
    private readonly DataContext context;
    private readonly ContactRepository contactRepository;

    public ContactController(DataContext context)
    {
      this.contactRepository = new ContactRepository(context);
      this.context = context;
    }

    [HttpGet("/api/contacts")]
    public IEnumerable<Contact> Get()
    {
      return context.Set<Contact>()
        .Include(c => c.Phones)
        .Include(c => c.Mails)
        .Include(c => c.Addresses)
        .ToList();
    }

    [HttpPost("/api/contacts")]
    public async Task<string> Post(ContactModel model)
    {
      if (!ModelState.IsValid)
      {
        return "El módelo no es válido";
      }
      try
      {
        await contactRepository.AddAsync(new Contact
        {
          Addresses = model.Addresses,
          Company = model.Company,
          Mails = model.Mails,
          Name = model.Name,
          Phones = model.Phones
        });
      }
      catch (Exception e)
      {
        return e.InnerException != null ? e.InnerException.Message : e.Message;
      }
      return "Operación exitosa";
    }

    [HttpPut("/api/contacts/{id}")]
    public async Task Put(ContactModel model, int id)
    {
      await contactRepository.UpdateAsync(new Contact
      {
        Addresses = model.Addresses,
        Company = model.Company,
        Mails = model.Mails,
        Name = model.Name,
        Phones = model.Phones
      }, id);
    }
  }
}
