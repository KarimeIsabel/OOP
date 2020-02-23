using System;

namespace Peliculas
{
   class Pelicula
    {
         private string Titulo;
         private int Año;
         private string Pais;
         private string Director;
        
         //Metodos
       public Pelicula (string Titulo , int Año)
    {
        this.Titulo = Titulo;
        this.Año = Año ;
    }
    public void Imprime ()
    {
        Console.WriteLine(Titulo);
        Console.WriteLine(Año);
    }
    public void setTitulo (string titulo)
    
    {
        this.Titulo = titulo ;
       
    } 
    public string getTitulo ()
    {
        return Titulo;
    }
    public void setAño(int año)
    {
       this.Año = año ;
    }
    public int getAño ()
    {
        return Año;
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula P1 = new Pelicula ("El viaje de chihiro",2001) ;
            Pelicula P2 = new Pelicula ("Toy Story 4",2019);
           
            P1.Imprime();
            P2.Imprime();
            
        }
    }
}
