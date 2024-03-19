namespace OperacoesComDoubles;

public class OperacoesMatematicas
{
    private double Valor1 { get; }
    private double Valor2 { get; set; }

    public OperacoesMatematicas(double valor1, double valor2)
    {
        Valor1 = valor1;
        Valor2 = valor2;
    }

    public void Soma() 
    {
        Console.WriteLine($"Soma: {Valor1 + Valor2}");
    }

    public void Subtracao()
    {
        Console.WriteLine($"Subtração: {Valor1 - Valor2}");
    }

    public void Multiplicacao()
    {
        Console.WriteLine($"Multiplicação: {Valor1 * Valor2}");
    }

    public void Divisao()
    {
        var resultado = Valor2 != 0 ? $"Divisão: {Valor1 / Valor2}" : "Divisão: Não é possível dividir por zero!";

        Console.WriteLine(resultado);

    }

    public void Media()
    {
        Console.WriteLine($"Media: {(Valor1 + Valor2) / 2}");
    }
}
