namespace agenda.Data.Entities
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Number { get; set; }
        public bool IsActive { get; set; }
        public int PhoneTypeId { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
