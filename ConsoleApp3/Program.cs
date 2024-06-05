using ConsoleApp3;



class Program
{
    static List<Department> departments = new List<Department>
        {
            new Department("Pediatriya", new List<Doctor>
            {
                new Doctor("Ali", "Aliyev", 10),
                new Doctor("Veli", "Veliev", 5),
                new Doctor("Sara", "Quliyeva", 8)
            }),
            new Department("Travmatologiya", new List<Doctor>
            {
                new Doctor("Hasan", "Hasanov", 12),
                new Doctor("Nigar", "Mammadova", 7)
            }),
            new Department("Stamotologiya", new List<Doctor>
            {
                new Doctor("Leyla", "Huseynova", 15),
                new Doctor("Kamran", "Jafarov", 6),
                new Doctor("Narmin", "Qasimova", 9),
                new Doctor("Rasim", "Ibrahimov", 4)
            })
        };

    static void Main(string[] args)
    {
        while (true)
        {
            User user = GetUserInformation();
            Department selectedDepartment = SelectDepartment();
            Doctor selectedDoctor = Doctor.SelectDoctor(selectedDepartment);
            Doctor.ReserveAppointment(user, selectedDoctor);
        }
    }

    static User GetUserInformation()
    {
        Console.WriteLine("Adınızı daxil edin:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Soyadınızı daxil edin:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Emailinizi daxil edin:");
        string email = Console.ReadLine();

        Console.WriteLine("Telefon nomrenizi daxil edin:");
        string phone = Console.ReadLine();

        return new User(firstName, lastName, email, phone);
    }

    static Department SelectDepartment()
    {
        Console.WriteLine("Zehmet olmasa sobeni secin:");
        for (int i = 0; i < departments.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {departments[i].Name}");
        }

        int departmentIndex = int.Parse(Console.ReadLine()) - 1;
        return departments[departmentIndex];
    }





}

    

    

    

    

