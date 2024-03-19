using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AluguelCarro
{
    public static float CalcularAluguel(int totalDias, float kmInicial, float kmFinal)
    {
        float valorDiaria = 95.00f;
        float valorPorKm = 0.35f;

        float valorTotalDiarias = totalDias * valorDiaria;
        float kmPercorridos = kmFinal - kmInicial;
        float valorTotalKm = kmPercorridos * valorPorKm;

        return valorTotalDiarias + valorTotalKm;
    }
}
