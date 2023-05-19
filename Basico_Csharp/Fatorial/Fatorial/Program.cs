namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            Console.WriteLine("Fatorial de 1 a 10:");

            for (int i = 1; i<=10;i++)
            {
                numero *= i;
                Console.WriteLine($"{i}! = {numero}");
            }
        }
    }
}