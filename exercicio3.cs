using System;
namespace exercicio3
{
    pulbic class Program
    {
        pulbic static void Main (string[] args)
        {
           Console.Write("!---------Estrutura WHILE---------!\n\n");//\n\n para pular duas linhas
           i=0, j=0, vet=0;
            //Defininado o tamnho do vetor
            Console.WriteLine("Entre com o tamnho do vetor: ");
            vet=int.Parse(Console.Readline());
            int[] medVet = new int [vet];// vetor assumindo o tamanho entrado pelo usuário

            //preenchendo o vetor
            Console.WriteLine("                    ATENÇÃO!!!\n"+
            "Se o dado informado for igual a zero o vetor não sera mais preenchido,\n"+
            "mesmo que o valor total do vetor nao tenha sido ocpupado, neste caso, as\n"+
            "demais posições do vetor assumirão o valor zero!");
            while (i<vet)
            {
                Console.WriteLine("Entre com o valor do "+j+"º vetor: ");
                medVet[i]=int.Parse(Console.ReadLine());
                if(medVet[i]=0);
                {
                    while(i+1<vet)
                    {
                        medVet[i+1]=0;
                        i++;
                    }
                }
                i++;
                j++;
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