using System;

public class Program
{
	public static void Main()
	{
		int a = 0, b=1, c=0, p=0, m=0, s=0;
		double media = 0;
		// a - contador do tamanho do vetor
		// b - impressao do numero entrada
		// c - zerando o vetor
		// p - impressao do vetor
		// m - numeros de elementos nao nulos do vetor
		// s - soma o valor dos valores do vetor
		Console.WriteLine("Entre como o tamanho do vetor: ");
		int tamanho_vet = int.Parse(Console.ReadLine());
		int [] vet = new int[tamanho_vet];

		//mensagem de advertência
		Console.WriteLine("                    ATENÇÃO!!!\n" +
		"Se o dado informado for igual a zero o vetor não sera mais preenchido,\n" +
		"mesmo que o valor total do vetor nao tenha sido ocpupado. Neste caso, as\n" +
		"demais posições do vetor assumirão o valor zero!");

		while (a < tamanho_vet)
        {
			Console.Write("Entre com " + b + "º valor do vetor: ");
			vet [a] = int.Parse(Console.ReadLine());
			s = s + vet[a];
			if (vet [a] == 0)
            {
				c = a;
				m = a;
                while (c < tamanho_vet)
                {
					vet[c] = 0;
					c++;
                }
				a = tamanho_vet;
            }
            else
            {
				a++;
				b++;
            }
			
        }
		Console.WriteLine(" a = "+a+"\n b = "+b+"\n c = "+c+"\n m = "+m+"\n s = "+s+"\n tamanho_vet = "+tamanho_vet+"\n");
		while (p < tamanho_vet) 
		{
			Console.Write(vet[p] + " ");
			p++;
		}
		if (m == 0)
		{
			media = s / (double)tamanho_vet;
			Console.WriteLine("\n\n A media dos valores do vetor é: *" + media);
        }
        else
        {
			media = s / (double)m;
			Console.Write("\n\n A media dos valores do vetor é: **" + media);
		}
		Console.ReadLine();
	}
}
