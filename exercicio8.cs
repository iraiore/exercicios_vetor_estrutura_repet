using System;
namespace exercicio8
{
    public class Program
    {
        public static void Main (string[] argas)
        {
            string continuar="", aluno=""; float nota1=0, nota2=0, media=0;//declaração de variaveis
            do
            {
                //entrando com os dados do aluno e calculando a media
                Console.WriteLine("Entre com o nome do aluno: ");
                aluno=Console.ReadLine();
                Console.WriteLine("\nEntre com a 1º nota do aluno" );
                nota1=float.Parse(Console.ReadLine());
                Console.WriteLine("\nEntre com a 2º nota do aluno" );
                nota2=float.Parse(Console.ReadLine());
                media=(nota1+nota2)/2;
                //definindo a sistuação do aluno de acordo com a media das notas
                if(media>=0 && media<5)
                {
                    Console.WriteLine("\nA aluno "+aluno+" esta reprovado. Media: "+media);
                }else if(media>=5 && media<7)
                {
                    Console.WriteLine("\nO aluno "+aluno+" esta exame. Media: "+media);
                }else
                {
                    Console.WriteLine("\nO aluno "+aluno+" esta aprovado. Media: "+media);
                }
                Console.WriteLine("\nDeseja entrar com dados de outro aluno?\nDigite s para sim e n para não");
                continuar=Console.ReadLine();
            }while(continuar == "s");
        }
    }
}