using system;
namespace exercicio2
{
    public class Program
    {
        public static void Main (string[] args)
        {
            Console.Write(""!---------Estrutura WHILE---------!\n\n"");
            //declaração de variáveis
            int[] mult = new int[10];
            int i=0, j=1; 
            //preenchendo o vetor
            while(i<10)
            {
                Cosole.WriteLine("Entre com "+j+"° valor do vetor: ");
                mult[i] = int.Parse(Console.ReadLine());
                i++;
                j++;
            }
            //estrutura para encontrar os valores multiplos de 3
            i=0;
            j=1;
            while(i<10)
            {
                if(mult[i]%3==0)
                {
                    Console.WriteLine("O "+j+"° valor é multiplo de 3: "+mult[i]);
                    i++;
                    j++;
                }
            }
            Console.ReadLine(); 
        }
    }
}