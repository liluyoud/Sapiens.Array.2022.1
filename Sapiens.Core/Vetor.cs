namespace Sapiens.Core;

public static class Vetor
{
    public static int[] CriaAleatorio(int tamaho)
    {
        var vetor = new int[tamaho];

        Random r = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(0, 100);
        }

        return vetor;
    }

    public static int Pesquisa(this int[] vetor, int valor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                return i;
            }
        }
        return -1;
    }

    public static string Texto(this int[] vetor)
    {
        var saida = "[";
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            saida = saida + vetor[i] + ",";
        }
        saida = saida + vetor[vetor.Length - 1] + "]";
        return saida;
    }

    public static int Soma(this int[] vetor)
    {
        var soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma = soma + vetor[i];
        }
        return soma;
    }

    public static int Maior(this int[] vetor)
    {
        var maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (maior < vetor[i]) 
                maior = vetor[i];
        }
        return maior;
    }

    public static int Menor(this int[] vetor)
    {
        var menor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (menor > vetor[i])
                menor = vetor[i];
        }
        return menor;
    }

    public static double Media(this int[] vetor)
    {
        var soma = Soma(vetor);
        return soma / vetor.Length;
    }
}
