class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o total de dias alugados:");
        int totalDias = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quilometragem inicial:");
        float kmInicial = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quilometragem final:");
        float kmFinal = float.Parse(Console.ReadLine());

        AluguelCarro aluguelCarro = new AluguelCarro();
        float totalAluguel = aluguelCarro.CalcularAluguel(totalDias, kmInicial, kmFinal);
        Console.WriteLine($"O valor total do aluguel é: R${totalAluguel:F2}");
    }
}