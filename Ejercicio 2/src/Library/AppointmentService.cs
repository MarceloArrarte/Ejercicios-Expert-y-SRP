using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /*
        La clase AppointmentService viola el principio SRP debido a que tiene más de un motivo para
        cambiar:
        1. Que los datos a almacenar del paciente cambien,
        2. Que los datos a almacenar del médico cambien,
        3. Que la validación de los datos cambie.

        Además, no sigue el patrón Expert. Uno de los requisitos es que el identificador
        de la consulta sea único, lo cual no se puede asegurar ya que la clase tendría para ello
        que conocer todas las instancias de una clase que almacenase los datos de las citas,
        lo cual no sucede en el código provisto.
        */
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
