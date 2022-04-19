using System;
namespace exercicio1
{
    class Program
    {
        static void Main (string[] args)
        {
            //Declaração de Variáveis
           int[] vetor = new int[30];
           int cont_ent=0, cont_impr=1, vet=0;//variaveis para  percorrer o vetor e impressao de mensagem e definir o tamnho do vetor
        
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
          
           Console.Write("Entre como  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());
           Console.Write("O vetor tera: "+vet+" posições!\n");

           //Preenchendo o vetor
           While(cont_ent<vet)
           {
             Console.WriteLine("Entre com o "+cont_impr+"° valor do vetor");
             vetor[cont_ent] = int.Parse(Console.ReadLine());
             cont_ent++;
             cont_impr++;
           }

        }
    }
}