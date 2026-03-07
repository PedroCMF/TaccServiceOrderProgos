namespace Tacc.serviceOrder.Domain.Entities
{
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty; 
        public string LastName { get; set; } = string.Empty;
        public string IpAdress   { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? ProfileImage{ get; set; }

    }
}
