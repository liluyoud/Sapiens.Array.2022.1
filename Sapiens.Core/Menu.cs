using static System.Console;

namespace Sapiens.Core;

public static class Menu
{
    public static void DesenhaTitulo(string titulo, int tamanho = 60)
    {
        if (titulo.Length % 2 == 1)
            titulo += " ";

        WriteLine($"+{RepeteCaracter("-", tamanho - 2)}+");

        var lado = RepeteCaracter(" ", (tamanho - 2 - titulo.Length) / 2);
        WriteLine($"|{lado}{titulo}{lado}|");

        WriteLine($"+{RepeteCaracter("-", tamanho - 2)}+");
    }

    public static string RepeteCaracter(string caracter, int vezes)
    {
        var texto = "";
        for (int i = 0; i < vezes; i++)
        {
            texto += caracter;
        }
        return texto;
    }
}
