using System;
using System.Collections.Generic;

namespace ListPeliculas
{
    public class Pelicula
    {
        private string Nombre;
        private Int16 Año;
        public Pelicula(string nombre, Int16 año)
        {
            this.Nombre= nombre;
            this.Año=año;
        }
        public void imprime()
        {
            Console.WriteLine("Titulo: "+Nombre);
            Console.WriteLine("Año: "+ Año);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> p1=new List<Pelicula>();
            p1.Add(new Pelicula("El viaje de chihiro",2001));
            p1.Add(new Pelicula ("Toy Story 4",2019));
            p1.Add(new Pelicula("La lista de Schindler",1993));
            p1.Add(new Pelicula ("Gladiator",2000));
            p1.Add(new Pelicula("El Señor de los Anillos: el retorno del Rey",2003));
            
            foreach(Pelicula año in p1)
            {
                año.imprime();
            }
        }
    }
}