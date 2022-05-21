using System;
namespace exercicio1
{
    public class Program
    {
        public static void Main (string[] args)
        {
           Console.Write("!-----------------------ESTRUTURA WHILE-----------------------!\n\n");
           int i=0, j=1, vet=0;//declaração de variáveis 
           //definindo o tamanho do vetor - o exercicio pede 30 valores
           Console.Write("Entre com  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());
           Console.Write("\nO vetor tera: "+vet+" posições!\n");
           int[] vetor = new int[vet];
           //preenchendo o vetor com a estrutura while
           while (i < vet)
           {
            Console.WriteLine("\nEntre com o "+j+"° valor do vetor");
            vetor[i] = int.Parse(Console.ReadLine());
            i++;j++;             
           }
           //impressão do vetor de forma crescente com a estrutura for
           Console.WriteLine("\nOs valores do vetor de "+vet+" posições são: \n");
           for(int a = 0; a < vet; a++)
           {
               for (int b = 0; b <= a; b++)
               {
                   Console.Write(vetor[b]+" ");
               }
		       Console.WriteLine("\n");
           }
           //encontrando e imprimindo os valores maiores que 100
           i=0; j=0;//zerando os contadores novamente para percorrerem o vetor 
           Console.WriteLine("\nOs valores maiores que 100 são: \n");
           while (i < vet)
           {
               if(vetor[i] > 100)
               {
                   Console.Write(vetor[i]+",");
               }
               i++;
           }
           Console.WriteLine("\n\nPressione a tecla Enter para iniciar a estrutura do..while");
           Console.ReadLine();
           Console.Write("!-----------------------ESTRUTURA DO... WHILE-----------------------!\n\n");
           vet=0; i=0; j=1;//zerando os contadores para serem utilzados na estrutura do...while
           //definindo o tamanho do vetor - o exercicio pede 30 valores
           Console.Write("Entre com  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());
           Console.Write("\nO vetor tera: "+vet+" posições!\n");
           int[] vetorD = new int[vet];//foi necessário criar outro vetor, pois, nao sei reinicializar e reutilizar o mesmo vetor para estrutura while
           //preenchendo o vetor com a estrutura do... while
           do
           {
             Console.WriteLine("\nEntre com o "+j+"° valor do vetor");
             vetorD[i] = int.Parse(Console.ReadLine());
             i++; j++;
           }while (i < vet);
           //impressão do vetor de forma decrescente com a estrutura for
           Console.WriteLine("\nOs valores do vetor de "+vet+" posições são: \n");
           for(int a = vet; a > 0; a--)
           {
                for (int b = a-1; b >= 0; b--)
                {
                    Console.Write(vetorD[b]+" ");
                }
		        Console.WriteLine("\n");
            }
            //encontrando e imprimindo os valores maiores que 100
            i=0; j=0; //zerando os contadores novamente para percorrerem o vetor 
            Console.WriteLine("\nOs valores maiores que 100 são: \n");
            do
            {
                if(vetorD[i] > 100)
                {
                    Console.Write(vetorD[i]+" ,");
                }
                i++;
            }while(i < vet);  
            Console.ReadLine();    
        }
    }
}
