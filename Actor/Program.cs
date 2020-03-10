using System;
using System.Collections.Generic;

namespace ListPeliculas
{
    public class Actor
    {
        private string Nombre;
        private int AñoNac;

        public Actor(string Nombre, int AñoNac)
        {
            this.Nombre=Nombre;
            this.AñoNac=AñoNac;
        }

        public void setNombre(string n)
        {
            this.Nombre=n;
        }
        public String getNombre()
        {
            return Nombre;
        }

        public void setAñoNac(int x)
        {
            this.AñoNac=x;
        }
        public int getAñoNac()
        {
            return AñoNac;
        }
    }

    public class Pelicula
    {
        private string Nombre;
        private Int16 Año;
        private List<Actor>Actores;
        public Pelicula(string nombre, Int16 año)
        {
            this.Nombre= Titulo;
            this.Año=año;
            Actores=new List<Actor>();
        }
      public void setTitulo(string t)
        {
            this.Nombre=t;
        }
        public string gretTitulo()
        {
            return Nombre;
        }

        public void setAño (Int16 y)
        {
            this.Año=y;
        }
        public int getAño ()
        {
         return Año;
        }

        public void AgregarActor(Actor A)
        {
         Actores.Add(A);
        }
        public void imprime()
        {
            Console.WriteLine("Titulo: "+Nombre);
            Console.WriteLine("Año: "+ Año);
            foreach(Actor a in Actores)
            {
                Console.WriteLine(a.getNombre());
                Console.WriteLine(a.getAñoNac());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula ("Historia de un matrimonio",2016);
            p1.AgregarActor(new Actor("Scarlett Johansson",1984));
            p1.AgregarActor(new Actor ("Adam Drive",1983));
           
            p1.imprime();
            
        }
    }
}
