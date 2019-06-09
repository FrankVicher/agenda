using System.Collections.Generic;

namespace agenda.Data.Entities
{
    public class Contact : IContact
  {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Mail> Mails { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
