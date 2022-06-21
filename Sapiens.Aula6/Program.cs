using Sapiens.Core;

Menu.DesenhaTitulo("Desafio de Programação");
DesafioTeste();
Desafio11();
Desafio12();
Desafio21();
Desafio22();
Desafio3();
Console.ReadLine();

// dado um vetor mostrar apenas os números pares do vetor
void DesafioTeste()
{
    Console.WriteLine("\nDesafio Teste");
    var vetor = Vetor.CriaAleatorio(20);
    Console.WriteLine(vetor.Texto());
    foreach (var numero in vetor)
    {
        if (numero % 2 == 0) // é par
        {
            Console.Write(numero + ", ");
        }
    }
    Console.WriteLine();
}

// dado um vetor quantos números pares e números impares tem
void Desafio11()
{
    Console.WriteLine("\nDesafio 11");
    var vetor = Vetor.CriaAleatorio(20);
    Console.WriteLine(vetor.Texto());
    int totalPar = 0;
    int totalImpar = 0;
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] % 2 == 0)
            totalPar++;
        else
            totalImpar++;
    }
    Console.WriteLine($"Total de números pares: {totalPar}");
    Console.WriteLine($"Total de números ímpares: {totalImpar}");
    Console.WriteLine();
}

void Desafio12()
{
    Console.WriteLine("\nDesafio 12");
    var vetor = Vetor.CriaAleatorio(20);
    Console.WriteLine(vetor.Texto());
    int totalPar = 0;
    int totalImpar = 0;
    foreach (var numero in vetor)
    {
        if (numero % 2 == 0)
            totalPar++;
        else
            totalImpar++;
    }
    Console.WriteLine($"Total de números pares: {totalPar}");
    Console.WriteLine($"Total de números ímpares: {totalImpar}");
    Console.WriteLine();
}

void Desafio21()
{
    Console.WriteLine("\nDesafio 21");
    var vetor = Vetor.CriaAleatorio(20);
    Console.WriteLine(vetor.Texto());

    for (int i = 0; i < vetor.Length - 1; i++)
    {
        if (vetor[i] < vetor[i + 1])
            vetor[i] = 0;
    }
    Console.WriteLine(vetor.Texto());

    Console.WriteLine();
}

void Desafio22()
{
    Console.WriteLine("\nDesafio 22");
    var entrada = Vetor.CriaAleatorio(10);
    var saida = new int[entrada.Length];
    Console.WriteLine(entrada.Texto());
    Console.WriteLine(saida.Texto());

    for (int i = 0; i < entrada.Length - 1; i++)
    {
        if (entrada[i] < entrada[i + 1])
            saida[i] = 0;
        else 
            saida[i] = entrada[i];
    }
    saida[saida.Length - 1] = entrada[entrada.Length - 1];

    Console.WriteLine("Após execução");
    Console.WriteLine(entrada.Texto());
    Console.WriteLine(saida.Texto());
    Console.WriteLine();
}

void Desafio3()
{
    Console.WriteLine("\nDesafio 3");
     var vetor = Vetor.CriaAleatorio(30);

    for (int i = 0; i < vetor.Length - 1; i++)
    {
        var numero = vetor[i];
        for (int j = i + 1; j < vetor.Length; j++)
        {
            if (vetor[j] == numero)
            {
                vetor[i] = 0;
                vetor[j] = 0;
            }
        }
    }

    Console.WriteLine(vetor.Texto());
    Console.WriteLine();
}
