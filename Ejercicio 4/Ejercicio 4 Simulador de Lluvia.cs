using System;
class Program
{
    static void Main()
    {
        double lluvia;
        double total = 0;
        double promedio;
        double mayor = 0;

        int dias = 0;
        int diasLluvia = 0;
        int diasSinLluvia = 0;

        while (true)
        {
            Console.Write("Ingresa los mm de la lluvia y -0 para terminar: ");
            lluvia = double.Parse(Console.ReadLine());

            if (lluvia < 0)
            {
                break;
            }

            dias = dias + 1;
            total = total + lluvia;

            if (lluvia > 20)
            {
                diasLluvia = diasLluvia + 1;
            }

            if (lluvia == 0)
            {
                diasSinLluvia = diasSinLluvia + 1;
            }

            if (lluvia > mayor)
            {
                mayor = lluvia;
            }
        }

        if (dias > 0)
        {
            promedio = total / dias;
        }
        else
        {
            promedio = 0;
        }

        Console.WriteLine();
        Console.WriteLine("Los dias con lluvia superior a 20 mm: " + diasLluvia);
        Console.WriteLine("Los Dias sin lluvia: " + diasSinLluvia);
        Console.WriteLine("Total de lluvia: " + total + " mm");
        Console.WriteLine("Promedio de lluvia: " + promedio + " mm");
        Console.WriteLine("El día más lluvioso: " + mayor + " mm");
    }
}