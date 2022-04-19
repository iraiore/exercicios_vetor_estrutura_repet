using System;
namespace exercicio1
{
    public class Program
    {
        public static void Main (string[] args)
        {
            //Declaração de Variáveis
           int i=0, j=1, vet=0;//variaveis para  percorrer o vetor e impressao de mensagem e definir o tamnho do vetor
        
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
          
           //Dados de entrada do usuário para deterinar o tamanho do vetor - o exercicio pede um vetor de 30 posições
           Console.Write("Entre com  tamanho do vetor: \n");
           vet = int.Parse(Console.ReadLine());
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
            //IMPRIMINDO O VETOR DE  FORMA CRESCENTE COM A ESTRUTURA DO FOR
             Console.WriteLine("\nO vetor de "+vet+" posições é: \n");
            for(int a=0; a<vet; a++)
            {
	        //Console.Write("\na= "+a+"\n");//entendendo o laço for para impressao no estilo crescente variavel a
                for (int b=0;b<=a;b++)
                {
                    Console.Write(vetor[b]+" ");
		    //Console.Write("b= "+b+" \n");//entendendo o laço for para impressao no estilo crescente variavel b - funço aninhada
                }
		Console.WriteLine("\n");//pular uma linha para cada impressão do vetor com o contador b
            }
            //ENCONTRANDO E IMPRIMINDO OS VALORES MAIORES QUE 100
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
             Console.ReadLine();
        }
    }
}
