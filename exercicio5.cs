using System;
namespace exercicio5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int b = 1, posit = 0, negat = 0; double somaP = 0, somaN = 0, media = 0;//declaração de variáveis
            do
            {
                Console.WriteLine("Digite um valor: ");
                b = int.Parse(Console.ReadLine());
                if(b > 0)
                {
                    somaP = somaP + b;
                    posit++;
                }else if(b < 0)
                {
                    somaN = somaN + b;
                    negat++;
                }
            }while (b != 0 );
            //calculando a media dos valores positivos e negativos
            media = somaP / posit;
            Console.WriteLine("a media dos valores positivos é: "+ media);
            media = somaN / negat;
            Console.WriteLine("a media dos valores negativos é: "+ media);
            Console.ReadLine();   
        }
    }
}