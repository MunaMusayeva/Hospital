namespace ConsoleApp3;

class User : Person
{
    public string Email { get; }
    public string Phone { get; }

    public User(string firstName, string lastName, string email, string phone)
        : base(firstName, lastName)
    {
        Email = email;
        Phone = phone;
    }
}
