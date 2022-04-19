using System;
namespace exercicio1
{
    class Program
    {
        static void Main (string[] args)
        {
            //Declaração de Variáveis
           int[] vetor = new int[30];
           int i=0, j=1, vet=0;//variaveis para  percorrer o vetor e impressao de mensagem e definir o tamnho do vetor
        
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
          
           Console.Write("Entre com  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());
           Console.Write("O vetor tera: "+vet+" posições!\n");
           Console.WriteLine("o valor das variaveis i e j são respectivamente: "+i+","+j);

           //Preenchendo o vetor
           while (i<vet)
           {
             Console.WriteLine("Entre com o "+j+"° valor do vetor");
             vetor[i] = int.Parse(Console.ReadLine());
             i++;
             j++;
           }
        }
    }
}