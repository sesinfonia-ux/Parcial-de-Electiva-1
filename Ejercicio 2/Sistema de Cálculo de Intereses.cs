using System;
class Program
{
    static void Main()
    {
        double monto;
        double saldo;
        double interes;
        double interestotal = 0;
        int meses = 0;

        Console.Write("Ingresa tu monto inicial: ");
        monto = double.Parse(Console.ReadLine());

        saldo = monto;

        while (saldo <= 2000)
        {
            interes = saldo * 0.05;
            saldo = saldo + interes;
            interestotal = interestotal + interes;
            meses = meses + 1;

            Console.WriteLine("Mes " + meses + ": $" + saldo);
        }

        Console.WriteLine();
        Console.WriteLine("Meses pasados: " + meses);
        Console.WriteLine("Interés total generado: $" + interestotal);
        Console.WriteLine("Saldo final: $" + saldo);
    }
}