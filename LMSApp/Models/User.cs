namespace LMSApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public User()
        {

        }

        public User(int id, string firstName, string lastName, DateOnly birthdate, string email, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
