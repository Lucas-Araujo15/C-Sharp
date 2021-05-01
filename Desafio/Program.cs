using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 5){
                Console.Write("Não há categorias para essa faixa etária");
            }
            else if (idade >= 5 && idade <= 7){

                Console.Write("A sua categoria é Infantil A");
            }
            else if (idade > 7 && idade <= 10){
                Console.Write("A sua categoria é Infantil B");
            }
            else if (idade > 10 && idade <= 13){
                Console.Write("A sua categoria é Juvenil A");
            }
            else if (idade > 13 && idade <= 17){
                Console.Write("A sua categoria é Juvenil B");
            }
            else if (idade > 18){
                Console.Write("A sua categoria é Sênior");
            }
        }
    }
}
