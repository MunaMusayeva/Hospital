namespace ConsoleApp3;

class Department
{
    public string Name { get; }
    public List<Doctor> Doctors { get; }

    public Department(string name, List<Doctor> doctors)
    {
        Name = name;
        Doctors = doctors;
    }
}
