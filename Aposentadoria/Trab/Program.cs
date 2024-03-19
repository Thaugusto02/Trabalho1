using System;

namespace AposentadoriaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade atual:");
            int idadeAtual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a idade em que deseja se aposentar:");
            int idadeAposentadoria = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor mensal a ser investido:");
            float valorMensal = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a taxa de rendimento mensal (em decimal):");
            float taxaRendimentoMensal = Convert.ToSingle(Console.ReadLine());
            float montanteAcumulado = AposentadoriaCalculadora.CalcularMontanteAcumulado(idadeAtual, idadeAposentadoria, valorMensal, taxaRendimentoMensal);
            float rendaMensal = AposentadoriaCalculadora.CalcularRendaMensal(montanteAcumulado, taxaRendimentoMensal);

            Console.WriteLine($"O montante acumulado ao se aposentar será: R$ {montanteAcumulado:F2}");
            Console.WriteLine($"A renda mensal durante a aposentadoria será: R$ {rendaMensal:F2}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
