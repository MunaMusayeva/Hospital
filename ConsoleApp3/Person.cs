namespace ConsoleApp3;

abstract class Person
{
    public string FirstName { get; }
    public string LastName { get; }

    protected Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
