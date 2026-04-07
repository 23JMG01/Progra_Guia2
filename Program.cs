internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dia de La Semana");

        int dia;
        dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("miercoles");
                break;
            case 4:
                Console.WriteLine("jueves");
                break;
            case 5:
                Console.WriteLine("viernes");
                break;
            case 6:
                Console.WriteLine("sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Digite un numero del 1 al 7");
                break;
        }
        }
}
