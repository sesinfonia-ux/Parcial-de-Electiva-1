using System;
class Program
{
    static void Main()
    {
        double saldo;
        double retiro;
        double totalRetirado = 0;
        double promedio = 0;

        int retiros = 0;

        Console.Write("Ingresa tu saldo inicial: ");
        saldo = double.Parse(Console.ReadLine());

        while (saldo > 0)
        {
            Console.Write("¿Cuánto deseas retirar? ");
            retiro = double.Parse(Console.ReadLine());

            if (retiro < 0)
            {
                break;
            }

            if (retiro > saldo)
            {
                Console.WriteLine("No puede retirar más del saldo disponible.");
            }
            else
            {
                saldo = saldo - retiro;
                totalRetirado = totalRetirado + retiro;
                retiros = retiros + 1;

                Console.WriteLine("Retiro hecho.");
                Console.WriteLine("Saldo actual: $" + saldo);
            }
        }

        if (retiros > 0)
        {
            promedio = totalRetirado / retiros;
        }

        Console.WriteLine();
        Console.WriteLine("Total retirado: $" + totalRetirado);
        Console.WriteLine("Número de retiros: " + retiros);
        Console.WriteLine("Promedio de los retiros: $" + promedio);
        Console.WriteLine("Saldo restante: $" + saldo);
    }
}