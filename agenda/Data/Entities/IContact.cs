using System.Collections.Generic;

namespace agenda.Data.Entities
{
  public interface IContact
  {
    List<Address> Addresses { get; set; }
    string Company { get; set; }
    int ContactId { get; set; }
    List<Mail> Mails { get; set; }
    string Name { get; set; }
    List<Phone> Phones { get; set; }
  }
}