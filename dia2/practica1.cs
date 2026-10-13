Console.WriteLine("Conversion de Gs a USD");
Console.WriteLine("--------------------------");
Console.WriteLine("Escriba la cotizacion del dolar: ");
double cotizaciones = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escriba el monto en gauranies a convertir: ");
double guaranies = Convert.ToDouble(Console.ReadLine());
double USD;
USD = guaranies /  cotizaciones;
Console.WriteLine($"Son {USD:N2} USD");
