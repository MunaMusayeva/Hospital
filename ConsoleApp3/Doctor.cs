namespace ConsoleApp3;

class Doctor : Person
{
    public int Experience { get; }
    public string[] AppointmentTimes { get; }
    public bool[] Reserved { get; }

    public Doctor(string firstName, string lastName, int experience)
        : base(firstName, lastName)
    {
        Experience = experience;
        AppointmentTimes = new[] { "09:00-11:00", "12:00-14:00", "15:00-17:00" };
        Reserved = new bool[3];
    }

    public static void ReserveAppointment(User user, Doctor doctor)
    {
        while (true)
        {
            Console.WriteLine($"Zehmet olmasa saatı secin ({doctor.FirstName} {doctor.LastName}):");
            for (int i = 0; i < doctor.AppointmentTimes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {doctor.AppointmentTimes[i]} - {(doctor.Reserved[i] ? "rezerv olunub" : "rezerv olunmayıb")}");
            }

            int timeIndex = int.Parse(Console.ReadLine()) - 1;

            if (!doctor.Reserved[timeIndex])
            {
                doctor.Reserved[timeIndex] = true;
                Console.WriteLine($"Tesekkurler {user.FirstName} {user.LastName}, siz saat {doctor.AppointmentTimes[timeIndex]}-da {doctor.FirstName} hekimin qebuluna yazildiniz.");
                break;
            }
            else
            {
                Console.WriteLine("Hemin vaxt artiq rezerv olunub, zehmet olmasa basqa vaxt secin.");
            }
        }
    }
    public static Doctor SelectDoctor(Department department)
    {
        Console.WriteLine($"Zehmet olmasa {department.Name} sobesinde bir hekim secin:");
        for (int i = 0; i < department.Doctors.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {department.Doctors[i].FirstName} {department.Doctors[i].LastName} ({department.Doctors[i].Experience} il tecrube)");
        }

        int doctorIndex = int.Parse(Console.ReadLine()) - 1;
        return department.Doctors[doctorIndex];
    }

}
