namespace ExibirDataAtual;

public static class FormatadorDeDatas
{
    private readonly static DateTime data = DateTime.UtcNow;

    public static void FormatoCompleto() => Console.WriteLine(data.ToString("dddd, dd/MM/yyyy HH:mm:ss"));

    public static void FormatoBrasileiro() => Console.WriteLine(data.ToString("dd/MM/yyyy"));

    public static void Formato24Horas() => Console.WriteLine(data.Hour);


    public static void FormatoMesExtenso() => Console.WriteLine(data.ToString("dd/MMMM/yyyy"));
}
