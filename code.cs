using System;

public class Computadora 
{
    private Procesador procesador;
    
    public Computadora()
    {
        procesador= new Procesador();
        procesador. Marca="AMD";
        
    }
    public void Encender()
    {
    Console.WriteLine("La computadora esta encendida");
    
    procesador.mostrarMarca();
    }

    


}


public class Procesador
{
    public string Marca {get; set;}
    
    public void mostrarMarca()=> Console.WriteLine($"El procesador de la computadora es {Marca}");
    
    
}

class program
{
    static void Main()
    {
    
     Computadora Pc= new Computadora();
     Pc.Encender();
    }
}
