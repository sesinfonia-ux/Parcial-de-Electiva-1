using System;
class Program
{
    static void Main()
    {
        int stock;
        int vendidos;

        int dias = 0;
        int totalVendido = 0;
        int mayor = 0;
        int menor = 0;

        double promedio;

        Console.Write("Ingresa el stock inicial: ");
        stock = int.Parse(Console.ReadLine());

        while (stock > 0)
        {
            Console.Write("Ingrese las unidades que han sido vendidas hoy: ");
            vendidos = int.Parse(Console.ReadLine());

            if (vendidos > stock)
            {
                Console.WriteLine("No hay unidades disponibles para vender.");
            }
            else
            {
                stock = stock - vendidos;
                totalVendido = totalVendido + vendidos;
                dias = dias + 1;

                if (dias == 1)
                {
                    mayor = vendidos;
                    menor = vendidos;
                }
                else
                {
                    if (vendidos > mayor)
                    {
                        mayor = vendidos;
                    }

                    if (vendidos < menor)
                    {
                        menor = vendidos;
                    }
                }
            }
        }

        if (dias > 0)
        {
            promedio = (double)totalVendido / dias;
        }
        else
        {
            promedio = 0;
        }

        Console.WriteLine();
        Console.WriteLine("Días que duró el stock: " + dias);
        Console.WriteLine("Promedio de unidades vendidas por día: " + promedio);
        Console.WriteLine("Máxima venta diaria: " + mayor);
        Console.WriteLine("Mínima venta diaria: " + menor);
    }
}