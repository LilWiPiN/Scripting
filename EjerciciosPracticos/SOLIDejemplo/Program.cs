using System;

public interface IPago
{
    void ProcesarPago(decimal monto);
}

public interface IAutenticacion
{
    void AutenticarUsuario(string usuario, string password);
}

public class PagoConTarjeta : IPago, IAutenticacion
{
    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto} con tarjeta.");
    }

    public void AutenticarUsuario(string usuario, string password)
    {
        Console.WriteLine("Autenticando usuario para pago con tarjeta.");
    }
}

public class PagoConPaypal : IPago
{
    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto} con PayPal.");
    }
}

public class PagoConEfectivo : IPago
{
    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto} en efectivo.");
    }
}

public class ProcesadorDePagos
{
    private readonly IPago _metodoDePago;

    public ProcesadorDePagos(IPago metodoDePago)
    {
        _metodoDePago = metodoDePago;
    }

    public void ProcesarPago(decimal monto)
    {
        _metodoDePago.ProcesarPago(monto);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPago pagoConTarjeta = new PagoConTarjeta();
        IPago pagoConPaypal = new PagoConPaypal();
        
        ProcesadorDePagos procesador = new ProcesadorDePagos(pagoConTarjeta);
        procesador.ProcesarPago(100.0m);

        procesador = new ProcesadorDePagos(pagoConPaypal);
        procesador.ProcesarPago(200.0m);
    }
}

