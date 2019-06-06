using System.ComponentModel.DataAnnotations.Schema;

namespace agenda.Data.Entities
{
    [Table("MailTypes")]
    public class MailType
    {
        public int MailTypeId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
