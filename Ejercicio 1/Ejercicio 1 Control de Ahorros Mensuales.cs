using System;
class Program
{
    static void Main()
    {
        double meta = 1000;
        double ahorro;
        double total = 0;
        double menor = 0;
        double mayor = 0;
        double promedio;
        int meses = 0;

        Console.WriteLine("AHORROS MENSUALES");
        Console.WriteLine();

        while (total < meta)
        {
            Console.Write("Ingresa cuanto ahorraste este mes: ");
            ahorro = double.Parse(Console.ReadLine());

            total = total + ahorro;
            meses = meses + 1;

            if (meses == 1)
            {
                menor = ahorro;
                mayor = ahorro;
            }
            else
            {
                if (ahorro < menor)
                {
                    menor = ahorro;
                }

                if (ahorro > mayor)
                {
                    mayor = ahorro;
                }
            }
        }

        promedio = total / meses;

        Console.WriteLine();
        Console.WriteLine("La meta alcanzada: $" + total);
        Console.WriteLine("Meses que le tomo: " + meses);
        Console.WriteLine("Promedio de ahorro mensual: $" + promedio);
        Console.WriteLine("Menor monto ahorrado: $" + menor);
        Console.WriteLine("Mayor monto ahorrado: $" + mayor);
    }
}