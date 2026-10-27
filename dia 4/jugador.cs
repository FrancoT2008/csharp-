
using System;

class Jugador
{
    public string Nombre;
    public int Vida;

    public Jugador(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public void RecibirAtaque(int puntos) 
    {
        Vida = Vida - puntos;
    }
    public void Curar(int puntos)
    {
        Vida = Vida + puntos;
    }
    public void Mostrar()
    {
        Console.WriteLine($"{Nombre} tiene {Vida} de vida");
    }
}

class Program 
{
    static void Main() 
    {
        //pelea de jugadores 
        Jugador j1 = new Jugador("Franco", 50);
        Jugador j2 = new Jugador("Torres", 40);

        j1.RecibirAtaque(25);
        j2.RecibirAtaque(15);
        j1.Mostrar();
        j2.Mostrar();
        Console.WriteLine("15 minutos de descanso");
        j1.Curar(15);
        j2.Curar(5);
        j1.Mostrar();
        j2.Mostrar();
    }
} 