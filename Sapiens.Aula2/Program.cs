using static System.Console;

// parte 1
Write("Informe o tamanho do vetor: ");
var tamanho = Convert.ToInt32(ReadLine());

// parte 2
var vetor = new int[tamanho];

// parte 3
for (int i = 0; i < tamanho; i++)
{
    vetor[i] = i * 2;
}

// parte 4
Write("[");
for (int i = 0; i < tamanho - 1; i++)
{
    Write($"{vetor[i]}, ");
}
WriteLine($"{vetor[tamanho - 1]}]");

// parte 5
var soma = 0;
foreach (var item in vetor)
{
    soma += item;
}
WriteLine($"A soma dos elementos é {soma}");

// parte 6
var media = soma / tamanho;
WriteLine($"A média dos elementos é {media}");
