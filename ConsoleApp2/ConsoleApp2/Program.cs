// Susing System;

class Program
{
    static void Main()
    {
        int sector, cantidad;
        double precio = 0, total;

        Console.WriteLine("Seleccione sector:");
        Console.WriteLine("1 → Palco (Q300)");
        Console.WriteLine("2 → Tribuna (Q100 - Q125)");
        Console.WriteLine("3 → Preferencia (Q50 - Q75)");
        Console.WriteLine("4 → Generales (Q30 - Q50)");
        sector = int.Parse(Console.ReadLine());

        Console.Write("Cantidad de entradas: ");
        cantidad = int.Parse(Console.ReadLine());

        switch (sector)
        {
            case 1:
                precio = 300;
                break;
            case 2:
                precio = 112.5; // promedio
                break;
            case 3:
                precio = 62.5; // promedio
                break;
            case 4:
                precio = 40; // promedio
                break;
            default:
                Console.WriteLine("Sector inválido");
                return;
        }

        total = precio * cantidad;
        Console.WriteLine("Total a pagar: Q" + total);
    }
}
