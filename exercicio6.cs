using System;
namespace exercicio6
{
    public class Program
    {
        public static void Main (string[] args)
        {
            int a = 1, entrada = 0, soma = 0;//declaração de variáveis
            //verificando se o valor é menor que zero e somando os numeros negativos
            while (a != 0)
            {
                Console.WriteLine("Digite um valor: ");
                entrada = int.Parse(Console.ReadLine());
                if (entrada < 0)
                {
                    soma = soma + entrada;
                }
                a = entrada;
            }
            Console.WriteLine("A soma dos números negativos é: "+ soma);
            Console.ReadLine();
        }
    }
}