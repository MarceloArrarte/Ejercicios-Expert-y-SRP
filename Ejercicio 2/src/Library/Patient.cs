namespace Library {
    public class Patient {
        private string _nombre;
        public string Nombre {
            get {return this._nombre;}
            set {
                if (! ValidationUtils.IsValidString(value)) {
                    throw new System.Exception("El nombre del paciente no es válido.");
                }
                this._nombre = value;
            }
        }

        private string _telefono;
        public string Telefono {
            get {return this._telefono;}
            set {
                if (! ValidationUtils.IsValidString(value)) {
                    throw new System.Exception("El teléfono del paciente no es válido.");
                }
                this._telefono = value;
            }
        }

        public Patient(string nombre, string telefono) {
            this.Nombre = nombre;
            this.Telefono = telefono;
        }
    }
}