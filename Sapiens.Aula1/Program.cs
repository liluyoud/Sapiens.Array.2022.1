// trabalhando com variáveis que armazena 1 único valor
int nota0 = 5;
int nota1 = 6;
int nota2 = 7;
int nota3 = 8;
int nota4 = 9;
int nota5 = 10;
int nota6 = 4;
int nota7 = 3;
int nota8 = 2;
int nota9 = 1;

Console.WriteLine(nota0);
Console.WriteLine(nota1);
Console.WriteLine(nota2);
Console.WriteLine(nota3);
Console.WriteLine(nota4);
Console.WriteLine(nota5);
Console.WriteLine(nota6);
Console.WriteLine(nota7);
Console.WriteLine(nota8);
Console.WriteLine(nota9);

// ou trabalhando com vetor

int[] notas = { 5, 6, 7, 8, 9, 10, 4, 3, 2, 1 };

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine(notas[i]);
}