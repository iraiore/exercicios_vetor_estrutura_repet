using System;
namespace exercicio3
{
    public class Program
    {
        public static void Main (string[] args)
        {
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
           int i=0, j=1, k=0, vet=0;
            //Defininado o tamnho do vetor
            Console.WriteLine("Entre com o tamnho do vetor: ");
            vet=int.Parse(Console.ReadLine());
            int[] medVet = new int [vet];// vetor assumindo o tamanho entrado pelo usuário

            //preenchendo o vetor
  using System;
namespace exercicio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
            int i = 0, j = 1, k = 0, vet = 0, soma = 0;
            float med = 0;

            //Defininado o tamanho do vetor
            Console.WriteLine("Entre com o tamanho do vetor: ");
            vet = int.Parse(Console.ReadLine());
            int[] medVet = new int[vet];// vetor sendo criado e assumindo o tamanho com valor entrado pelo usuário

            //mensagem de advertência
            Console.WriteLine("                    ATENÇÃO!!!\n" +
            "Se o dado informado for igual a zero o vetor não sera mais preenchido,\n" +
            "mesmo que o valor total do vetor nao tenha sido ocpupado. Neste caso, as\n" +
            "demais posições do vetor assumirão o valor zero!");
            
            //preechendo o vetor
            while (i < vet)
            {
                Console.WriteLine("\nEntre com o valor do " + j + "º vetor: ");
                medVet[i] = int.Parse(Console.ReadLine());
                //alocando zero na posição i ate o fim do vetor caso digite zero
                if (medVet[i] == 0)
                {
                    k = i;//equiparando os dois contadores para verificar se o vetor naquela posição é zero e zerar o restante
                    while (k < vet)
                    {
                        medVet[k] = 0;
                        k++;
                    }
                    i = vet;//condição para encerrar o while o valor digitado seja zero   
                }
                else
                {
                    i++;
                    j++;
                }
            }

            //verificando quantos valores são não nulos
            i = 0;//zerando o contador i
            k = 0;//zerando o contador k
            while (i < vet)
            {
                if (medVet[k] != 0)
                {
                    k++;
                }
                else
                {
                    i = vet;
                }
            }
            //somando os valores do vetor
            k = 0;
            while (k < vet)
            {
                soma=soma+medVet[k];
                k++;
            }
            //imprimindo o vetor na tela
            Console.WriteLine("\n\nO vetor é: ");
            i = 0;
            while (i < vet)
            {
                Console.Write(medVet[i] + " ");
                i++;
            }
            //calculando e imprimindo a media do vetor considerando os valares não nulos e nulos
            med = soma / vet;
            Console.WriteLine("\n\nA media do vetor considerando o tamanho do vetor é: "+med);
            Console.WriteLine("soma: "+soma+";"+"tamanho do vetor "+vet);//teste
            med = soma / k;
            Console.WriteLine("\n\nA media do vetor considerando os valores não nulos é: " + med);
            Console.WriteLine("soma: " + soma + ";" + "tamanho do vetor " + vet);//teste
            Console.ReadLine();
        }
    }
}
