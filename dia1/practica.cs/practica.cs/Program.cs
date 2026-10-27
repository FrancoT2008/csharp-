using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        DateTime ahora = DateTime.Now;
        Console.WriteLine("Fecha: " + ahora.ToString("dd/MM/yyyy"));
        Console.WriteLine("Hora: " + ahora.ToString("HH:mm"));
        Console.WriteLine("Dia de la Semana: " + ahora.DayOfWeek);
        Console.WriteLine("Faltan " + (19 - ahora.Hour) + " horas para el cierre.");
    }
}