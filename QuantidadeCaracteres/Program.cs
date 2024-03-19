namespace QuantidadeCaracteres;

class Program
{
    static void Main(string[] args)
    {
        VerificaQuantidadeCaracteres();

        Console.WriteLine("Programa Finalizado!");
    }

    static void VerificaQuantidadeCaracteres()
    {
        string palavra;
        while ((palavra = ObterPalavraDoUsuario()) != "SAIR")
        {
            palavra = palavra.Replace(" ", "");

            if (palavra.Length > 0)
                Console.WriteLine($"A palavra possui {palavra.Length} caracteres\n");
        }
    }

    static string ObterPalavraDoUsuario()
    {
        Console.Write("Digite uma palavra para saber a quantidade de caracteres ou digite SAIR para encerrar o programa: ");

        return Console.ReadLine().ToUpper();
    }
}
