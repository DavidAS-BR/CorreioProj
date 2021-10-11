using System;
using System.Collections.Generic;
using System.Text;

namespace CorreioProj
{
    class LogisticaEntrega // Classe que decide qual será a próxima caixa a ser entregue
    {
        public static Caixa decidirProximaEntrega(List<Caixa> armarzem)
        {
            Caixa entregaCaixa = null;

            foreach (Caixa caixa in armarzem)
            {
                entregaCaixa = caixa;
                break;
            }

            return entregaCaixa; // Retornar próxima caixa que deverá ser entregue
        }
    }
}
