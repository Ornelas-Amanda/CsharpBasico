
namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplos de 3 :");
           // Double numero = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i <100; i++) 
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                } 
            }
        }


        }
    }
