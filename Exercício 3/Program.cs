using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 500) {
                double ajuste = salario * 1.3;
                Console.Write("O seu salário foi reajustado para " + ajuste.ToString("N2") + " reais");
            }

            else {
                Console.Write("O reajuste salarial não se aplica ao valor indicado");
            }
        }
    }
}
