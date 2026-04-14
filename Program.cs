using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un carácter: ");
        char c = Convert.ToChar(Console.ReadLine());

        if (char.IsDigit(c))
        {
            Console.WriteLine("Es un dígito");
        }
        else
        {
            char letra = char.ToUpper(c);
            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                Console.WriteLine("Es una vocal");
            else
                Console.WriteLine("No es vocal ni dígito");
        }
    }
}