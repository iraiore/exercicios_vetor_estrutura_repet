using System;
namespace exercicio1
{
    public class Program
    {
        public static void Main (string[] args)
        {
            //Declaração de Variáveis
           int[] vetor = new int[30];
           int i=0, j=1, vet=0;//variaveis para  percorrer o vetor e impressao de mensagem e definir o tamnho do vetor
        
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
          
           Console.Write("Entre com  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());
           Console.Write("\nO vetor tera: "+vet+" posições!\n");
           Console.WriteLine("\no valor das variaveis i e j são respectivamente: "+i+","+j);

           //Preenchendo o vetor
           while (i<vet-1)
           {
             Console.WriteLine("\nEntre com o "+j+"° valor do vetor");
             vetor[i] = int.Parse(Console.ReadLine());
             i++;
             j++;
             
            }
            //imprimindo o vetor em arvore com o a estrutura for
             Console.WriteLine("\nO vetor de "+vet+" posições é: ");
            for(int a=0; a<vet-1; a++)
            {
                for(int b=0;b<=a;b++)
                {
                Console.Write(vetor[b]);
                Console.WriteLine("\n");
                }
            }
             Console.ReadKey();
        }
    }
}
