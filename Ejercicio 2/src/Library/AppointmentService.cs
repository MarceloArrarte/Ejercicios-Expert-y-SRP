using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class AppointmentService
    {
        private static int lastAppointmentId = 0;
        private static List<Appointment> appointments = new List<Appointment>();
        
        public static string CreateAppointment(Patient paciente, DateTime date, string appointmentPlace, Doctor doctor)
        {
            int nextId = AppointmentService.GenerateNextAppointmentId();
            StringBuilder sb = new StringBuilder();
            sb.Append("Scheduling appointment...\n");
            AppointmentService.appointments.Add(new Appointment(
                nextId, date, appointmentPlace, paciente, doctor
            ));
            sb.Append("Appointment scheduled!");
            AppointmentService.lastAppointmentId = nextId;
            return sb.ToString();
        }

        private static int GenerateNextAppointmentId() {
            return AppointmentService.lastAppointmentId + 1;
        }
    }
}
