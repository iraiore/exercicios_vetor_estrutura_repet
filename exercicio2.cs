using System;
namespace exercicio2
{
    public class Program
    {
        public static void Main (string[] args)
        {
            Console.Write("!-----------------------ESTRUTURA WHILE-----------------------!\n\n");
            int i=0, j=1;//declaração de variáveis
            int[] mult = new int[10];//declarando vetor de 10 posições
            //preenchendo o vetor
            while(i < 10)
            {
                Console.WriteLine("Entre com "+j+"° valor do vetor: ");
                mult[i] = int.Parse(Console.ReadLine());
                i++; j++;
            }
            Console.Write("\n");
            //encontrando os valores multiplos de 3
            i=0; j=1;//reinicializando os cotadores para percorrerem o vetor
            while(i<10)
            {
                if(mult[i]%3 == 0)
                {
                    Console.WriteLine("O "+j+"° valor é multiplo de 3: "+mult[i]);
                }
                i++; j++;
            }
            Console.Write("\n\n!-----------------------ESTRUTURA DO... WHILE-----------------------!\n\n");
            //preenchendo o vetor com a estrutura do... while
            i=0; j=1;//reinicializando os contadors para serem utilizados na estrutura do...while
            do
            {
                Console.WriteLine("Entre com "+j+"° valor do vetor: ");
                mult[i] = int.Parse(Console.ReadLine());
                i++; j++;
            }while(i < 10);
            Console.Write("\n");
            //encontrando os valores multiplos de 3
            i=0; j=1;//reinicializando os contadors para serem utilizados na estrutura do...while
            do
            {
                if(mult[i] % 3 == 0)
                {
                    Console.WriteLine("O "+j+"° valor é multiplo de 3: "+mult[i]);
                }
                i++; j++;
            }while(i < 10);
            Console.ReadLine(); 
        }
    }
}