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
            vet=int.Parse(Console.Realine());
            int[] medVet = new int [vet];// vetor assumindo o tamanho entrado pelo usuário

            //preenchendo o vetor
            Console.WriteLine("                    ATENÇÃO!!!\n"+
            "Se o dado informado for igual a zero o vetor não sera mais preenchido,\n"+
            "mesmo que o valor total do vetor nao tenha sido ocpupado, neste caso, as\n"+
            "demais posições do vetor assumirão o valor zero!");
            while (i<vet)
            {
                Console.WriteLine("Entre com o valor do "+j+"º vetor: ");
            }            

        }
    }
}