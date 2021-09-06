using System;
using System.Collections;

namespace SRP
{
    public class Biblioteca {
        public string Nombre { get; }
        public string[] Sectores { get; }
        public string[] Estantes { get; }
        private ArrayList LibrosGuardados;

        public Biblioteca(string nombre, string[] sectores, string[] estantes) {
            this.Nombre = nombre;
            this.LibrosGuardados = new ArrayList();
            this.Sectores = sectores;
            this.Estantes = estantes;
        }

        public void AlmacenarLibro(Libro libro, string sector, string estante) {
            Console.Write($"Guardando {libro.Titulo} en {this.Nombre}, sector {sector}, estante {estante}...");
            LibrosGuardados.Add(libro);
            Console.WriteLine("¡Listo!");
        }
    }
}