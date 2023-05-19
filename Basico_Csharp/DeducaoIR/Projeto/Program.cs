using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcule a dedução do seu IR");
        Console.WriteLine("Salario:");
        double salario = Convert.ToDouble(Console.ReadLine()); ;
        double deducao;

        /*De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
          De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
          De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.*/

        if (salario >= 1900 && salario <= 2800)
        {
            deducao = salario * 0.075;
            Console.WriteLine($"o IR é de 7.5% e pode deduzir na declaração o valor de R${deducao}");
        }
        else if (salario >= 2800.01 && salario <= 3751.0)
        {
            deducao = salario * 0.15;
            Console.WriteLine($"o IR é de 15% e pode deduzir na declaração o valor de R${deducao}");
        }
        else if (salario >= 3751.01 && salario <= 4664.00)
        {
            deducao = salario * 0.225;
            Console.WriteLine($"o IR é de 22.5% e pode deduzir na declaração o valor de R${deducao}");
        }
        else {
            Console.WriteLine("Não a deduções ");
                }
    }
}