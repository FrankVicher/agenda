using agenda.Data.Entities;

namespace agenda.Data.Repositories
{
  public class ContactRepository : Repository<Contact>
  {
    public ContactRepository(DataContext context) : base(context)
    {
    }
  }
}
