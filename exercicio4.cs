using System;
namespace exercicio4
{
    public class Program 
    {
        public static void Main (string[] args)
        {
            int a = 0, b = 0, c = 1, soma=0, divisor=1;
            float media = 0;
            
            while(a >= 0)
            {
                Console.Write ("Entre com o "+c+"º numero: \n");
                b = int.Parse(Console.ReadLine());
                if (b < 0)
                {
                    divisor = a;
                    a = -1;
                }else
                {
                soma = soma + b;
                a++;c++;
                }
            }
            Console.WriteLine("\na = "+a+"\nb = "+b+"\nsoma = "+soma+"\ndivisor = "+divisor);
            media = b / divisor;
            Console.Write("\na media dos valores é: "+ media);
            Console.ReadLine();
        }
    }
}