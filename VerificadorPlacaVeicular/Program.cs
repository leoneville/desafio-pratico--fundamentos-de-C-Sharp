namespace VerificadorPlacaVeicular;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a placa do veículo: ");
        var placa = Console.ReadLine();

        var verificador = new VerificaPlacaValida(placa);
        verificador.ValidaPlacaVeicular();
    }
}