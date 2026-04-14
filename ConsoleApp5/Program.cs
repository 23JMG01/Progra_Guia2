using System;

class Program
{
    static void Main()
    {
        double num1, num2, resultado = 0;
        int opcion;

        Console.Write("Ingrese primer número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione opción:");
        Console.WriteLine("1 → Sumar");
        Console.WriteLine("2 → Restar");
        Console.WriteLine("3 → Multiplicar");
        Console.WriteLine("4 → Dividir");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("Error: división por cero");
                    return;
                }
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}