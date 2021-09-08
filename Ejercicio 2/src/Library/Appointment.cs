using System;

namespace Library {
    public class Appointment {
        private readonly int _id;
        public int ID {
            get {return this._id;}
        }

        private DateTime _fecha;
        public DateTime Fecha {
            get {return this._fecha;}
            set {
                if (! ValidationUtils.IsValidDate(value)) {
                    throw new System.Exception("La fecha de la consulta no es válida.");
                }
                this._fecha = value;
            }
        }

        private string _lugar;
        public string Lugar {
            get {return this._lugar;}
            set {
                if (! ValidationUtils.IsValidString(value)) {
                    throw new System.Exception("El lugar de la consulta no es válido.");
                }
                this._lugar = value;
            }
        }

        public Patient Paciente { get; set; }
        public Doctor Doctor { get; set; }

        internal Appointment(int id, DateTime fecha, string lugar, Patient patient, Doctor doctor) {
            this._id = id;
            this.Fecha = fecha;
            this.Lugar = lugar;
            this.Paciente = patient;
            this.Doctor = doctor;
        }
    }
}