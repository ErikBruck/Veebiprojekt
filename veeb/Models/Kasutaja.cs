namespace veeb.Models
{
    public class Kasutaja
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Kasutaja(int id, string userName, string password, string firstName, string lastName) 
        {
            Id = id;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
