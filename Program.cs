using System;

namespace Pelicula
{
    class Pelicula
    {
        public  string  titulo;
        public Int16 año;
        public string pais;
        public string director;



    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1= new Pelicula();
           p1.titulo="El viaje de chijiro";
           p1.año=2001;

           Pelicula p2= new Pelicula();
           p2.titulo="Toy Story 4";
           p2.año=2019;

// Impresiones
System.Console.WriteLine("Titulo: "+p1.titulo+"\nAño: "+p1.año );
System.Console.WriteLine("Titulo: "+p2.titulo+"\nAño: "+p2.año );


        }
    }
}
