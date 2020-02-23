using System;

namespace Peliculas
{
   class Pelicula
    {
         private string Titulo;
         private int Año;
         private string Pais;
         private string Director;
        //atributos
        private  string  titulo;
        private Int16 año;
        private string pais;
        private string director;
        
         //Metodos
        public string gettitulo()
        {
            return titulo;
        }
        public void settitulo(string Titulo)
        {
            titulo=Titulo;
        }
        public Int16 getaño() 
        {
            return año;
        }
        public void setaño(Int16 Año)
        {
            año=Año;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1= new Pelicula();
           p1.settitulo("El viaje de chijiro");
           p1.setaño(2001);
           Pelicula p2=new Pelicula();
           p2.settitulo("Toy Story 4");
           p2.setaño(2019);
           System.Console.WriteLine("Titulo: "+p1.gettitulo()+"\nAño: "+p1.getaño());
           System.Console.WriteLine("Titulo: "+p2.gettitulo()+"\nAño: "+p2.getaño());
        }
    }
}
