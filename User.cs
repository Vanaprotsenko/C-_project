namespace CRMSystem
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; } 

        public User(int id, string username, string password, string firstName, string lastName, Role role)
        {
            Id = id;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
    }
}
