using Sapiens.Core;

Menu.DesenhaTitulo("TRABALHANDO COM VETORES");

var vetor = Vetor.CriaAleatorio(20);

Console.WriteLine(vetor.Texto());

// dado um valor fornecido pelo usuário, verificar se 
// o mesmo se encontra no vetor

Console.Write("Informe um valor para consultar: ");
var valor = Convert.ToInt32(Console.ReadLine());

var posicao = vetor.Pesquisa(valor);

if (posicao >= 0)
{
    Console.WriteLine($"Existe o elemento {valor} na lista na posição {posicao}");
} else
{
    Console.WriteLine($"Não existe o elemento {valor} na lista");
}

Console.ReadLine();