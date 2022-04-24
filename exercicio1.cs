using System;
namespace exercicio1
{
    public class Program
    {
        public static void Main (string[] args)
        {
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas

           //Declaração de Variáveis
           int i=0, j=1, vet=0;//variaveis para  percorrer o vetor e impressao de mensagem e definir o tamnho do vetor  

           //bloco para entrada e leitura do usuário para determinar o tamanho do vetor - o exercicio pede um vetor de 30 posições
           Console.Write("Entre com  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());

           // mensagem anunciando o tamnho do vetor e o vetor assumindo o numero de posições
           Console.Write("\nO vetor tera: "+vet+" posições!\n");
           int[] vetor = new int[vet];

           //PREENCHENDO O VETOR COM A ESTRUTURA WHILE
           while (i<vet)
           {
             Console.WriteLine("\nEntre com o "+j+"° valor do vetor");
             vetor[i] = int.Parse(Console.ReadLine());
             i++;
             j++;             
            }

            //IMPRIMINDO O VETOR DE  FORMA CRESCENTE COM A ESTRUTURA FOR
           Console.WriteLine("\nO vetor de "+vet+" posições é: \n");
           for(int a=0; a<vet; a++)
           {
	            //Console.Write("\na= "+a+"\n");//entendendo o laço for para impressao no estilo crescente da variavel a
                for (int b=0;b<=a;b++)
                {
                    Console.Write(vetor[b]+" ");
		            //Console.Write("b= "+b+" \n");//entendendo o laço for para impressao no estilo crescente variavel b - funçao aninhada
                }
		        Console.WriteLine("\n");//pular uma linha para cada impressão do vetor com o contador b
            }

            //ENCONTRANDO E IMPRIMINDO OS VALORES MAIORES QUE 100
            //inicializando os contadores novamente para percorrer o vetor e encontrar os valores maiores que 100 
            i=0;
            j=0;
            Console.WriteLine("Os valores maiores que 100 são: \n");
            while (i<vet)
            {
                if(vetor[i]>100)
                {
                    Console.Write(vetor[i]+",");
                }
                i++;
            }
            Console.WriteLine("\nPressione qualquer tecla para iniciar a estrutura do..while");
            Console.ReadLine();

            Console.Write("!---------Estrutura DO... WHILE---------!\n\n");//\n\n para pular duas linhas
            //inicializando os vetores par aque seja utilzado na estrutura do...while
            vet=0;
            i=0;
            j=1;

           //bloco para entrada e leitura do usuário para determinar o tamanho do vetor - o exercicio pede um vetor de 30 posições
           Console.Write("Entre com  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());

           //mensagem anunciando o tamnho do vetor e o vetor assumindo o numero de posições
           Console.Write("\nO vetor tera: "+vet+" posições!\n");
           int[] vetorD = new int[vet];//necessario criar outro vetor pois, nao sei como reinicializar e reutilizar o mesmo vetor para estrutura do...while

           //PREENCHENDO O VETOR COM A ESTRUTURA DO... WHILE
           do
           {
             Console.WriteLine("\nEntre com o "+j+"° valor do vetor");
             vetorD[i] = int.Parse(Console.ReadLine());
             i++;
             j++;
           }while (i<vet);

           //IMPRIMINDO O VETOR DE  FORMA DECRESCENTE COM A ESTRUTURA FOR
           Console.WriteLine("\nO vetor de "+vet+" posições é: \n");
           for(int a=vet; a>0; a--)
           {
	            //Console.Write("\na= "+a+"\n");//entendendo o laço for para impressao no estilo crescente da variavel a
                for (int b=a;b>0;b--)
                {
                    Console.Write(vetorD[b-1]+" ");
		            //Console.Write("b= "+b+" \n");//entendendo o laço for para impressao no estilo crescente variavel b - funçao aninhada
                }
		        Console.WriteLine("\n");//pular uma linha para cada impressão do vetor com o contador b
            }
            Console.ReadLine();
        }
    }
}
