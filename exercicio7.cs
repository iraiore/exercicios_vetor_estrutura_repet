using System;
namespace exercicio7
{
    public class Program 
    {
        public static void Main (string[] args)
        {
            string continuar = "", funcionario = ""; float salario = 0;//declaração de variaveis
            //lendo e escrevendo os nomes dos funcionários que possuem salarios maior que 1000 reais
            do
            {
                Console.WriteLine ("Entre com o nome do funcionario:");
                funcionario=(Console.ReadLine());
                Console.WriteLine ("\nDigete o valor do salario do funcionario "+funcionario);
                salario = float.Parse(Console.ReadLine());
                if (salario > 1000)
                {
                    Console.WriteLine("\nO salario do funcionario "+funcionario+" é maior que R$ 1000,00");
                }
                Console.WriteLine("\n\nDeseja continuar entrado com dados de outros funcionarios: \n Digite s para sim e n para não ");
                continuar=(Console.ReadLine());
            }while (continuar == "s");
            Console.ReadLine();
        }
    }
}