using System;
namespace exercicio3
{
    public class Program
    {
        public static void Main (string[] args)
        {
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
           int i=0, j=1, k=0, vet=0, somaVet=0, med;
            //Defininado o tamnho do vetor
            Console.WriteLine("Entre com o tamnho do vetor: ");
            vet=int.Parse(Console.ReadLine());
            int[] medVet = new int [vet];// vetor assumindo o tamanho entrado pelo usuário

            //preenchendo o vetor
            Console.WriteLine("                    ATENÇÃO!!!\n"+
            "Se o dado informado for igual a zero o vetor não sera mais preenchido,\n"+
            "mesmo que o valor total do vetor nao tenha sido ocpupado, neste caso, as\n"+
            "demais posições do vetor assumirão o valor zero!");
            //preechendo o vetor
            while (i<vet)
            {
                Console.WriteLine("\nEntre com o valor do "+j+"º vetor: ");
                medVet[i]=int.Parse(Console.ReadLine());
               //alocando zero na posição i ate o fim do vetor caso o valor digitado seja zero
                if(medVet[i]==0)
                {
                    //estrutura para percorrer o vetor e zerar as demais posições
                    k=i;
                    while(k<vet)
                    {
                        medVet[k]=0;
                        k++;
                    }
                    //estrutura para contar quantos valores são maiores que zero e somar os dados do vetor
                    k=0;
                    while(medVet[k]>0)
                    {
                        somaVet=somaVet+medVet[k];
                        k++;
                    }
                    i=vet;
                }else
                {
                i++;
                j++;
                }
            }
            //imprimindo o vetor
            i=0;
            Console.Write("\nO vetor é: ");
            while(i<vet)
            {
            Console.Write(medVet[i]+",");
            i++;            
            }
            //média dos valores não nulos do vetor
            med=somaVet/k;
            Console.Write("\n\nA média dos valores não nulos do vetor é: "+med);
            med=somaVet/vet;
            Console.Write("\n\nA média dos valores considerando o tamanho do vetor é: "+med);
            Console.ReadLine();
        }
    }
}