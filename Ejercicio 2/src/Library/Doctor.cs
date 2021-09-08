namespace Library {
    public class Doctor {
        private string _nombre;
        public string Nombre {
            get {return _nombre;}
            set {
                if (! ValidationUtils.IsValidString(value)) {
                    throw new System.Exception("El nombre del doctor no es válido.");
                }
                this._nombre = value;
            }
        }

        public Doctor(string nombre) {
            this.Nombre = nombre;
        }
    }
}