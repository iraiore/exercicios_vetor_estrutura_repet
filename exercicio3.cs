using System;
namespace exercicio3
{
    public class Program
    {
        public static void Main (string[] args)
        {
           Console.Write("!-----------------------ESTRUTURA WHILE-----------------------!\n\n");
           int i=0, j=1, k=0, vet=0; double somaVet=0, med=0;//declaração de variáveis
            //Defininado o tamnho do vetor
            Console.WriteLine("Entre com o tamnho do vetor: ");
            vet=int.Parse(Console.ReadLine());
            int[] medVet = new int [vet];
            //mensagem alertando sobre a entrada zerada
            Console.WriteLine("                    ATENÇÃO!!!\n"+
            "Se o dado informado for igual a zero o vetor não sera mais preenchido,\n"+
            "mesmo que o valor total do vetor nao tenha sido ocpupado, neste caso, as\n"+
            "demais posições do vetor assumirão o valor zero!");
            //preechendo o vetor
            while (i < vet)
            {
                Console.WriteLine("\nEntre com o "+j+"º valor do vetor: ");
                medVet[i]=int.Parse(Console.ReadLine());
               //verificando se o valor é zero e zerando o restante do vetor
                if(medVet[i] == 0)
                {
                    k=i;
                    while(k < vet)
                    {
                        medVet[k]=0;
                        k++;
                    }
                    //contando os  valores maiores que zero e somando os dados do vetor
                    k=0;
                    while(medVet[k] > 0)
                    {
                        somaVet = somaVet + medVet[k];
                        k++;
                    }
                    i=vet;
                }else
                {
                i++;j++;
                }
            }
            //imprimindo o vetor
            i=0;
            Console.Write("\nOs valores do vetor são: ");
            while(i < vet)
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