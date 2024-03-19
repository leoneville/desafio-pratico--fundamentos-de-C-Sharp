namespace BoasVindasUsuario;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        var nomeUsuario = Console.ReadLine();

        Console.WriteLine($"Olá, {nomeUsuario}! Seja muito bem-vindo!");

        Console.ReadKey();
    }
}