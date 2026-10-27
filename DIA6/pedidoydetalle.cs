Producto gaseosa = new Producto("Gaseosa 500 ml", 6000);
PedidoDetalle linea = new PedidoDetalle(gaseosa, 3); // <- era coma

Console.WriteLine(linea.Cantidad + " x " + linea.Producto.Nombre + " = " + linea.Subtotal().ToString("N0") + " Gs");
Console.WriteLine("El producto existe por si solo: " + gaseosa.Nombre);

class Producto
{
    public string Nombre { get; }
    public double Precio { get; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class PedidoDetalle
{
    public Producto { get; } 
    public int Cantidad { get; }

    public PedidoDetalle(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
    }

    public double Subtotal()
    {
        return Producto.Precio * Cantidad;
    }
}