using System;

namespace AposentadoriaApp
{
    public class AposentadoriaCalculadora
    {
        public static float CalcularMontanteAcumulado(int idadeAtual, int idadeAposentadoria, float valorMensal, float taxaRendimentoMensal)
        {
            int mesesParaAposentadoria = (idadeAposentadoria - idadeAtual) * 12;
            float montanteAcumulado = 0;

            for (int i = 0; i < mesesParaAposentadoria; i++)
            {
                montanteAcumulado += valorMensal;
                montanteAcumulado *= (1 + taxaRendimentoMensal);
            }

            return montanteAcumulado;
        }

        public static float CalcularRendaMensal(float montanteAcumulado, float taxaRendimentoMensal)
        {
            return montanteAcumulado * taxaRendimentoMensal;
        }
    }
}
