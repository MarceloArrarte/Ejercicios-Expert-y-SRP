using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca1 = new Biblioteca("Biblioteca principal", new string[] {"A", "B", "C"}, new string[] {"1", "2", "3"});
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            biblioteca1.AlmacenarLibro(libro1, "A", "2");
            biblioteca1.AlmacenarLibro(libro2, "C", "1");
        }
    }
}
