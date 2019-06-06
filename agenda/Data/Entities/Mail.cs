namespace agenda.Data.Entities
{
    public class Mail
    {
        public int MailId { get; set; }
        public string MailAddress { get; set; }
        public MailType Type { get; set; }
        public bool IsActive { get; set; }
    }
}
