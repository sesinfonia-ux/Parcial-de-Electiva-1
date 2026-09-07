using System;

class Program
{
    static void Main()
    {
        int numero;

        int positivos = 0;
        int negativos = 0;

        double sumaPositivos = 0;
        double sumaNegativos = 0;

        double promedioPositivos = 0;
        double promedioNegativos = 0;

        int mayor = 0;
        int menor = 0;

        while (true)
        {
            Console.Write("Digita un número si el numero es 0 el programa terminara :): ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                break;
            }

            if (positivos == 0 && negativos == 0)
            {
                mayor = numero;
                menor = numero;
            }

            if (numero > 0)
            {
                positivos = positivos + 1;
                sumaPositivos = sumaPositivos + numero;
            }
            else
            {
                negativos = negativos + 1;
                sumaNegativos = sumaNegativos + numero;
            }

            if (numero > mayor)
            {
                mayor = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }
        }

        if (positivos > 0)
        {
            promedioPositivos = sumaPositivos / positivos;
        }

        if (negativos > 0)
        {
            promedioNegativos = sumaNegativos / negativos;
        }

        Console.WriteLine();
        Console.WriteLine("Cantidad de positivos: " + positivos);
        Console.WriteLine("Cantidad de negativos: " + negativos);
        Console.WriteLine("Promedio de positivos: " + promedioPositivos);
        Console.WriteLine("Promedio de negativos: " + promedioNegativos);
        Console.WriteLine("Número más alto: " + mayor);
        Console.WriteLine("Número más bajo: " + menor);
    }
}