using Sapiens.Core;

Menu.DesenhaTitulo("Desafio de Programação");
Desafio1();
Console.ReadLine();

// dado um vetor mostrar apenas os números pares do vetor
void Desafio1()
{
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

void Desafio2()
{

}

