using System.Text.RegularExpressions;

namespace VerificadorPlacaVeicular;

public class VerificaPlacaValida
{
    private string PlacaVeicular { get; set; }
    public VerificaPlacaValida(string placaVeicular)
    {
        PlacaVeicular = placaVeicular;
    }

    private bool IsAlphanumeric() => Regex.IsMatch(PlacaVeicular, @"^[a-zA-Z0-9]+$");

    private bool PrimeirasTresLetras() => Regex.IsMatch(PlacaVeicular[..3], @"^[a-zA-Z]+$");

    private bool UltimosQuatroNumeros() => Regex.IsMatch(PlacaVeicular[3..], @"^[0-9]+$");

    public void ValidaPlacaVeicular()
    {
        string resultado = (IsAlphanumeric() && PrimeirasTresLetras() && UltimosQuatroNumeros()) ? "Verdadeiro" : "Falso";

        Console.WriteLine(resultado);
    }
}
