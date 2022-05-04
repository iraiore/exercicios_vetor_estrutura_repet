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
            Console.WriteLine("                    ATENÇÃO!!!\n"+
            "Se o dado informado for igual a zero o vetor não sera mais preenchido,\n"+
            "mesmo que o valor total do vetor nao tenha sido ocpupado, neste caso, as\n"+
            "demais posições do vetor assumirão o valor zero!");
            //preechendo o vetor
            while (i<vet)
            {
                Console.WriteLine("\nEntre com o valor do "+j+"º vetor: ");
                medVet[i]=int.Parse(Console.ReadLine());
               //alocando zero na posição i ate o fim do vetor caso digite zero
                if(medVet[i]==0)
                {
                    k=i;
                    while(k<vet)
                    {
                        medVet[k]=0;
                        k++;
                    }
                    i=vet;
                }else
                {
                i++;
                j++;
                }
            }
            i=0;
            while(i<vet)
            {
            Console.Write(medVet[i]+",");
            i++;            
            }
            Console.ReadLine();
        }
    }
}