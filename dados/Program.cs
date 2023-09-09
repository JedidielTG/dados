using System;

class Program
{
    static void Main()
    {
        // En esta linea cree una instancia de la clase Random para generar números aleatorios.
        Random random = new Random();

        Console.WriteLine("Presiona Enter para lanzar el dado o presiona 'Q' y Enter para salir.");

        while (true)
        {
            // Coloque este funcion para que el usuario presione Enter y se lanzen los dados.
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Q)
            {
                //agregue una funcion para que el usuario salga del programa, si el usuario presiona 'Q'.
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                // Cuando el usuario presione el enter tambien muestra el resultado del dado.
                int resultadoDado = TirarDado(random);
                Console.WriteLine($"El dado ha obtenido un {resultadoDado}");
            }
        }
    }

    // Coloco las funciones para simular el lanzamiento de un dado de 6 caras.
    static int TirarDado(Random random)
    {
        // Genera un número aleatorio entre 1 y 6.
        int numeroAleatorio = random.Next(1, 7);
        return numeroAleatorio;
    }
}

