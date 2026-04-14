using System;

class Program
{
    static void Main()
    {
        int opcion;
        double valor;

        Console.WriteLine("Seleccione unidad:");
        Console.WriteLine("1 → Metros");
        Console.WriteLine("2 → Pies");
        Console.WriteLine("3 → Centímetros");
        Console.WriteLine("4 → Pulgadas");
        opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        valor = double.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Pies: " + (valor * 3.28084));
                Console.WriteLine("Centímetros: " + (valor * 100));
                Console.WriteLine("Pulgadas: " + (valor * 39.3701));
                break;
            case 2:
                Console.WriteLine("Metros: " + (valor / 3.28084));
                Console.WriteLine("Centímetros: " + (valor * 30.48));
                Console.WriteLine("Pulgadas: " + (valor * 12));
                break;
            case 3:
                Console.WriteLine("Metros: " + (valor / 100));
                Console.WriteLine("Pies: " + (valor / 30.48));
                Console.WriteLine("Pulgadas: " + (valor / 2.54));
                break;
            case 4:
                Console.WriteLine("Metros: " + (valor / 39.3701));
                Console.WriteLine("Pies: " + (valor / 12));
                Console.WriteLine("Centímetros: " + (valor * 2.54));
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}