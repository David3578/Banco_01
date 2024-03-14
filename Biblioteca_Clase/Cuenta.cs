namespace Biblioteca_Clase;
public class Cuenta
{
    public int CBU { get; }
    public decimal Saldo { get; private set; }
    public Cuenta(int cbu)
    {
        CBU = cbu;
        Saldo = 0;
    }
    public void Acreditar(decimal monto)
    {
        Saldo += monto;
    }
    public void Debitar(decimal monto)
    {
        if (PuedeDebitar(monto))
        {
            Saldo -= monto;
        }
        else
        {
            Console.WriteLine("No se puede debitar el monto especificado.");
        }
    }
    public bool PuedeDebitar(decimal monto)
    {
        return Saldo >= monto;
    }
}
