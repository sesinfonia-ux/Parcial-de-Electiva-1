using System;

class Program
{
    static void Main()
    {
        int edad;
        int menores = 0;
        int adultos = 0;
        int mayores = 0;
        int cantidad = 0;
        int sumaEdades = 0;
        double promedio;

        while (true)
        {
            Console.Write("Ingrese la edad y ingrese 0 para terminar");
            edad = int.Parse(Console.ReadLine());

            if (edad == 0)
            {
                break;
            }

            sumaEdades = sumaEdades + edad;
            cantidad = cantidad + 1;

            if (edad < 18)
            {
                menores = menores + 1;
            }
            else
            {
                if (edad <= 65)
                {
                    adultos = adultos + 1;
                }
                else
                {
                    mayores = mayores + 1;
                }
            }
        }

        if (cantidad > 0)
        {
            promedio = (double)sumaEdades / cantidad;
        }
        else
        {
            promedio = 0;
        }

        Console.WriteLine();
        Console.WriteLine("Menores de 18: " + menores);
        Console.WriteLine("Entre 18 y 65: " + adultos);
        Console.WriteLine("Mayores de 65: " + mayores);
        Console.WriteLine("Promedio de edad: " + promedio);
    }
}