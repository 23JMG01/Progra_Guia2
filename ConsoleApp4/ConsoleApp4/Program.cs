using System;

class Program
{
    static void Main()
    {
        int opcion;
        double angulo, radianes;

        Console.WriteLine("****************************************************");
        Console.WriteLine("*  CALCULADORA FUNCIONES TRIGONOMETRICAS BASICAS   *");
        Console.WriteLine("*                                                  *");
        Console.WriteLine("*  Lista de funciones trigonométricas              *");
        Console.WriteLine("*  1 - Seno                                        *");
        Console.WriteLine("*  2 - Coseno                                      *");
        Console.WriteLine("*  3 - Tangente                                    *");
        Console.WriteLine("****************************************************");

        Console.Write("\nIngrese el ángulo en grados: ");
        angulo = double.Parse(Console.ReadLine());

        // Convertir a radianes
        radianes = angulo * Math.PI / 180;

        Console.Write("Seleccione una opción (1-3): ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(radianes));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(radianes));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(radianes));
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}