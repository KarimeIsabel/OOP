using System;

namespace Pelicula
{
    class Pelicula
    {
         //atributos
        private  string  titulo;
        private Int16 año;
        private string pais;
        private string director;
        
        //constructores
        public Pelicula(string titulo1,Int16 año1,string pais1, string director1)
        {
            this.titulo=titulo1;
            this.año=año1;
            this.pais=pais1;
            this.director=director1;
        }

        public Pelicula()
        {
            titulo="El viaje de chihiro";
            año=2001;
            
        }

        //Metodos
        public void imprimir()
        {
            Console.WriteLine(titulo,año);
        }
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
            
            Pelicula p1= new Pelicula("El viaje de chihiro",2001,"Japon","Hayao Miyazaki");
           Pelicula p2= new Pelicula("Toy Story 4",2019,"USE","Josh Cooley");
           p1.imprimir();
           p2.imprimir();
           
        }
    }
}
