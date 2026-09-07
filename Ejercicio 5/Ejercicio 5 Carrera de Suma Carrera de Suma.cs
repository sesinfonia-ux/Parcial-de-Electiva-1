using System;
class Program
{
    static void Main()
    {
        int jugador1 = 0;
        int jugador2 = 0;

        int puntos1;
        int puntos2;

        int turnos = 0;
        int diferencia;

        while (jugador1 < 100 && jugador2 < 100)
        {
            Console.Write("Ingresa los Puntos del jugador 1: ");
            puntos1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa los Puntos del jugador 2: ");
            puntos2 = int.Parse(Console.ReadLine());

            jugador1 = jugador1 + puntos1;
            jugador2 = jugador2 + puntos2;

            turnos = turnos + 1;

            Console.WriteLine();
        }

        Console.WriteLine();

        if (jugador1 >= 100 && jugador2 >= 100)
        {
            Console.WriteLine("EMPATE");
            diferencia = 0;
        }
        else
        {
            if (jugador1 >= 100)
            {
                Console.WriteLine("Ha Ganado el jugador 1");
                diferencia = jugador1 - jugador2;
            }
            else
            {
                Console.WriteLine("Ha Ganado el jugador 2");
                diferencia = jugador2 - jugador1;
            }
        }

        Console.WriteLine("Turnos: " + turnos);
        Console.WriteLine("Puntaje jugador 1: " + jugador1);
        Console.WriteLine("Puntaje jugador 2: " + jugador2);
        Console.WriteLine("Ganó por " + diferencia + " puntos");
    }
}