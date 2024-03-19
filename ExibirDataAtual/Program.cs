namespace ExibirDataAtual;

class Program
{
    static void Main(string[] args)
    {
        var numero = MenuEscolha();
        DecisaoFormatoUsuario(numero);
    }

    static string? MenuEscolha()
    {
        Console.WriteLine("\t### Formato das Datas ###");
        Console.WriteLine("1 - Formato Completo\n2 - Apenas a data no formato \"01/03/2024\"\n3 - Apenas a hora no formato de 24 horas\n4 - A data com o mês por extenso");
        Console.Write("\nEscolha uma opção de 1 a 4: ");
        return Console.ReadLine();
    }

    static void DecisaoFormatoUsuario(string? escolha)
    {
        switch (escolha)
        {
            case "1":
                FormatadorDeDatas.FormatoCompleto();
                break;
            case "2":
                FormatadorDeDatas.FormatoBrasileiro();
                break;
            case "3":
                FormatadorDeDatas.Formato24Horas();
                break;
            case "4":
                FormatadorDeDatas.FormatoMesExtenso();
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }
    }
}
