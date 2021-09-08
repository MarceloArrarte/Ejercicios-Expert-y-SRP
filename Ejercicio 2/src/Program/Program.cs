using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Patient patient1 = new Patient("Steven Johnson", "5555-555-555");
            Doctor doctor1 = new Doctor("Armand");
            string appointmentResult = AppointmentService.CreateAppointment(patient1, DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult);
        }
    }
}
