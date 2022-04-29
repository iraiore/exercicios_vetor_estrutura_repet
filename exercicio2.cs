using System;
namespace exercicio2
{
    public class Program
    {
        public static void Main (string[] args)
        {
            Console.Write("!---------Estrutura WHILE---------!\n\n");
            //declaração de variáveis
            int[] mult = new int[10];
            int i=0, j=1; 
            //preenchendo o vetor
            while(i<10)
            {
                Console.WriteLine("Entre com "+j+"° valor do vetor: ");
                mult[i] = int.Parse(Console.ReadLine());
                i++;
                j++;
            }
            //estrutura para encontrar os valores multiplos de 3
            i=0;
            j=1;
            while(i<10)
            {
                if(mult[i]%3==0)
                {
                    Console.WriteLine("O "+j+"° valor é multiplo de 3: "+mult[i]);
                }
                i++;
                j++;
            }
            Console.Write("\n\n!---------Estrutura DO... WHILE---------!\n\n");//\n\n para pular duas linhas
            //inicializando os vetores par aque seja utilzado na estrutura do...while
            i=0;
            j=1;
            //preenchendo o vetor
            do
            {
                Console.WriteLine("Entre com "+j+"° valor do vetor: ");
                mult[i] = int.Parse(Console.ReadLine());
                i++;
                j++;
            }while(i<10);
            //estrutra para encontrar os valores multiplos de 3
            i=0;
            j=1;
            do
            {
                if(mult[i]%3==0)
                {
                    Console.WriteLine("O "+j+"° valor é multiplo de 3: "+mult[i]);
                }
                i++;
                j++;
            }while(i<10);
            Console.ReadLine(); 
        }
    }
}