using System;
namespace exercicio1
{
    class Program
    {
        static void Main (string[] args)
        {
            //Declaração de Variáveis
           int [] vetor = new int[30];
           int cont_entrada=0, cont_impr=0, vet=0;//variaveis para  percorrer o vetor e impressao de mensagem e definir o tamnho do vetor
        
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pualr duas linhas
           Console.Write("Entre como  tamnho do vetor: \n");
           vet = int.Parse(Console.ReadLine());
           Console.Write("O tamnho do vetor será: "+vet);

        }
    }
}