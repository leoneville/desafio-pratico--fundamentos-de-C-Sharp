using System.Text;

namespace ConcatenaNomeUsuario;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        var nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        StringBuilder sb = new();

        sb.Append(nome);
        sb.Append(' ');
        sb.Append(sobrenome);
        var nomeCompleto = sb.ToString();

        Console.WriteLine("\nNome Completo: " + nomeCompleto);
    }
}