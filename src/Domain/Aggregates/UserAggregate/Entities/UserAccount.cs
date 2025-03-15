namespace Domain.Aggregates.UserAggregate.Entities
{
    public class UserAccount : BaseEntity, IAggregateRoot
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserAccount(string email, string password) : base()
        {
            Email = email;
            Password = password;
        }
    }
}
