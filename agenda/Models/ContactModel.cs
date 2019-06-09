using agenda.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace agenda.Models
{
  public class ContactModel : IContact
  {
    [Required]
    public string Name { get; set; }
    public List<Address> Addresses { get; set; }
    public string Company { get; set; }
    public int ContactId { get; set; }
    public List<Mail> Mails { get; set; }
    public List<Phone> Phones { get; set; }
  }
}
