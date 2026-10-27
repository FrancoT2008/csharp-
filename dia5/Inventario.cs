List<Producto> inventario = new List<Producto>();
inventario.Add(new Producto("K001", "Gaseosa 500ml", 6000, 24, 6));
inventario.Add(new Producto("K002", "Alfajor", 3500, 40, 10));
inventario.Add(new Producto("K003", "Agua mineral", 4500, 8, 6));

inventario[0].vender(5);
inventario[2].vender(4);
inventario[1].vender(100);

Console.WriteLine("=== Inventario del Kiosco ===");
foreach (Producto p in inventario)
{
    p.mostrar();
}

class Producto
{
    private int _stock;
    private double _precioVenta;

    public string Codigo { get; }
    public string Nombre { get; }
    public int StockMinimo { get; }

    public double PrecioVenta
    {
        get { return _precioVenta; }
        set
        {
            if (value > 0)

                _precioVenta = value;

        }
    }

    public int Stock
    {
        get { return _stock; }
    }

    public Producto(string codigo, string nombre, double precioVenta, int stock, int stockMinimo)
    {
        Codigo = codigo;
        Nombre = nombre;
        PrecioVenta = precioVenta;
        _stock = stock;
        StockMinimo = stockMinimo;
    }

    public bool vender(int cantidad)
    {
        if (cantidad <= 0 || cantidad > _stock)
        {
            Console.WriteLine($"No se puede vender " + cantidad + " unidades de " + Nombre + ". Stock disponible: " + _stock);
            return false;
        }
        _stock -= cantidad;
        return true;
    }

    public void Reponer(int cantidad)
    {
        if (cantidad > 0)
            _stock += cantidad;
    }

    public bool necesitaReposicion()
    {
        return _stock <= StockMinimo;
    }

    public void mostrar()
    {
        string aviso = "";
        if (necesitaReposicion())
            aviso = " [reponer] ";
        Console.WriteLine(Codigo + " " + Nombre + " - " + PrecioVenta.ToString("N0") + "Gs - stock: " + _stock + aviso);
    }
}