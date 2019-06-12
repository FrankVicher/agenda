using System;
using System.Linq;
using System.Threading.Tasks;
using agenda.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace agenda.Data.Repositories
{
  public class ContactRepository : Repository<Contact>
  {
    private readonly DataContext context;

    public ContactRepository(DataContext context) : base(context)
    {
      this.context = context;
      
    }

    internal async Task UpdateAsync(Contact contact, int id)
    {
      var entity = context.Set<Contact>().Find(id);      
      //entity.Addresses = contact.Addresses;
      
      entity.Company = contact.Company;
      //entity.Mails = contact.Mails;
      entity.Name = contact.Name;
      //entity.Phones = contact.Phones;
      context.Entry(entity).State = EntityState.Modified;
      await context.SaveChangesAsync();
      contact.Phones.ForEach(p => {
        if (!context.Set<Phone>().Any(e => e.PhoneId == p.PhoneId))
        {
          context.Set<Phone>().Add(p);          
        }
        else
        {
          context.Entry<Phone>(p).State = EntityState.Modified;          
        }        
      });
      await context.SaveChangesAsync();
    }
  }
}
