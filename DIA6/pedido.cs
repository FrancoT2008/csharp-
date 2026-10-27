using System;

// Clase base
public class Persona
{
    public string Nombre { get; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public void Presentarse()
    {
        Console.WriteLine("Hola, mi nombre es " + Nombre + ".");
    }
}

// Cliente hereda de Persona
public class Cliente : Persona
{
    public string Telefono { get; }

    public Cliente(string nombre, string telefono) : base(nombre)
    {
        Telefono = telefono;
    }
}

public class Producto { }

public class PedidoDetalle { }

public class Pedido { }

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Lucia Benitez", "0981 123 456");

        cliente.Presentarse();
        Console.WriteLine("Telefono: " + cliente.Telefono);
    }
}

