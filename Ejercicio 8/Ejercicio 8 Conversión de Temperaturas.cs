using System;
class Program
{
    static void Main()
    {
        double temperatura;
        double fahrenheit;

        double suma = 0;
        double promedio;

        double mayor = 0;
        double menor = 0;

        int cantidad = 0;
        int bajoCero = 0;
        int sobre30 = 0;

        while (true)
        {
            Console.Write("Ingresa la temperatura en °C: ");
            temperatura = double.Parse(Console.ReadLine());

            if (temperatura < -100 || temperatura > 100)
            {
                break;
            }

            fahrenheit = (temperatura * 9 / 5) + 32;

            Console.WriteLine("La temperatura en Fahrenheit: " + fahrenheit);

            suma = suma + temperatura;
            cantidad = cantidad + 1;

            if (temperatura < 0)
            {
                bajoCero = bajoCero + 1;
            }

            if (temperatura > 30)
            {
                sobre30 = sobre30 + 1;
            }

            if (cantidad == 1)
            {
                mayor = temperatura;
                menor = temperatura;
            }
            else
            {
                if (temperatura > mayor)
                {
                    mayor = temperatura;
                }

                if (temperatura < menor)
                {
                    menor = temperatura;
                }
            }
        }

        if (cantidad > 0)
        {
            promedio = suma / cantidad;
        }
        else
        {
            promedio = 0;
        }

        Console.WriteLine();
        Console.WriteLine("Temperaturas bajo 0 °C: " + bajoCero);
        Console.WriteLine("Temperaturas sobre 30 °C: " + sobre30);
        Console.WriteLine("Promedio de temperaturas: " + promedio + " °C");
        Console.WriteLine("Temperatura más alta: " + mayor + " °C");
        Console.WriteLine("Temperatura más baja: " + menor + " °C");
    }
}