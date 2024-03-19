namespace OperacoesComDoubles;

internal class Program
{
    static void Main(string[] args)
    {
        var numero1 = ObterNumeroUsuario("Digite o primeiro número: ");
        var numero2 = ObterNumeroUsuario("Digite o segundo número: ");

        var operacoes = new OperacoesMatematicas(numero1, numero2);
        operacoes.Soma();
        operacoes.Subtracao();
        operacoes.Multiplicacao();
        operacoes.Divisao();
        operacoes.Media();
    }

    static double ObterNumeroUsuario(string mensagem)
    {
        bool exitoConversao;
        double numero;

        do
        {
            Console.Write(mensagem);
            var entrada = Console.ReadLine();
            exitoConversao = double.TryParse(entrada, out numero);

            if (!exitoConversao)
            {
                Console.WriteLine("Por favor, digite somente números!");
                continue;
            }

        } while (!exitoConversao);

        return numero;
    }
}
