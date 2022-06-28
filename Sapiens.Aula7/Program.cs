using static System.Console;

int[,] matriz1 = new int[2, 2];
int[,] matriz2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
int[,] matriz3 = { { 1, 2 }, { 3, 4 } };


WriteLine($"Dimensoes da matriz: {matriz1.Rank}");
WriteLine($"Dimensoes da matriz: {matriz2.Rank}");
WriteLine($"Dimensoes da matriz: {matriz3.Rank}");

WriteLine("Escrevendo a matriz 2 manualmente");
WriteLine($"{matriz2[0, 0]}, {matriz2[0, 1]}");
WriteLine($"{matriz2[1, 0]}, {matriz2[1, 1]}");

matriz1[0, 0] = 11;
matriz1[0, 1] = 12;
matriz1[1, 0] = 21;
matriz1[1, 1] = 22;

WriteLine("Escrevendo a matriz 1 com for");
for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        WriteLine(matriz1[i, j]);
    }
}

Clear();
var matriz4 = CriaMatriz(4, 6);
MostrarMatriz(matriz4);
ReadLine();

ZeraImpar(matriz4);
MostrarMatriz(matriz4);

ReadLine();

void ZeraImpar(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (matriz[i,j] % 2 == 1)
                matriz[i,j] = 0;
        }
    }
}

int[,] CriaMatriz(int altura, int largura)
{
    var matriz = new int[altura, largura];
    Random r = new Random();
    for (int i = 0; i < altura; i++)
    {
        for (int j = 0; j < largura; j++)
        {
            matriz[i, j] = r.Next(1, 99);
        }
    }
    return matriz;
}

void MostrarMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        Write("|");
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (j == 0)
                Write(string.Format("{0,2}", matriz[i, j]));
            else
                Write(string.Format("{0,5}", matriz[i, j]));
        }
        WriteLine("|");
    }
}