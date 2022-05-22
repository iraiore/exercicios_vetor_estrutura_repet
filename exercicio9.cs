using System;
namespace exercicio9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string continuar="", produto=""; double preco=0;//declaração de variáveis
            
            do
            {
                Console.WriteLine("Entre com o nome do produto:");
                produto=Console.ReadLine();
                Console.WriteLine("Entre com o preço do produto: ");
                preco=double.Parse(Console.ReadLine());
                preco=preco*1.15;
                Console.WriteLine("\nO preço acrescido de 15% é:\nProduto: "+produto+"\nNovo Preço: R$ "+preco);
                Console.WriteLine("\n\nDeseja calcular o preço de outro produto?\nDigite s para sim e n para não");
                continuar=Console.ReadLine();
            }while(continuar=="s");
        }
    }
}