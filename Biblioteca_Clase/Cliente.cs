namespace Biblioteca_Clase;
using System;
public class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public decimal SaldoEnEfectivo { get; set; }
    public Cuenta Cuenta { get; set; }
    public Cliente(string nombre, string apellido, decimal saldoEnEfectivo, int cbu)
    {
        Nombre = nombre;
        Apellido = apellido;
        SaldoEnEfectivo = saldoEnEfectivo;
        Cuenta = new Cuenta(cbu);
    }
    public void Acreditar(decimal monto)
    {
        decimal montoEfectivo = monto * 0.8m;
        decimal montoCuenta = monto * 0.2m;
        SaldoEnEfectivo += montoEfectivo;
        Cuenta.Acreditar(montoCuenta);
    }
    public void Debitar(decimal monto)
    {
        decimal montoEfectivo = monto * 0.8m;
        decimal montoCuenta = monto * 0.2m;
        if (SaldoEnEfectivo >= montoEfectivo && Cuenta.PuedeDebitar(montoCuenta))
        {
            SaldoEnEfectivo -= montoEfectivo;
            Cuenta.Debitar(montoCuenta);
        }
        else
        {
            Console.WriteLine("No se puede debitar el monto especificado.");
        }
    }
    public int ObtenerCBUCuenta()
    {
        return Cuenta.CBU;
    }
    public decimal ObtenerSaldo()
    {
        return SaldoEnEfectivo + Cuenta.Saldo;
    }
}
