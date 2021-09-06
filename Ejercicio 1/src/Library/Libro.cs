using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        /*
        Las siguientes propiedades violan aquí el principio de SRP, ya que la responsabilidad
        de conocer los datos de almacenaje no debería recaer en el libro. Si lo hacen, como
        en este caso, implica que la clase Libro puede cambiar tanto si se deciden cambiar los
        datos del libro que se almacenan (agregando por ejemplo ISBN), como si se cambia la
        estructura de almacenamiento del mismo (agregando por ejemplo número de sala).
        */
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
