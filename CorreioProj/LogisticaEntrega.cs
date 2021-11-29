using System;
using System.Collections.Generic;
using System.Text;

namespace CorreioProj
{
    class LogisticaEntrega // Classe que decide qual será a próxima caixa a ser entregue
    {
        // Essa é a menira "menos inteligente" de decidir a próxima entrega, pois ela segue o método "FIFO" para entrega das caixas.
        // Ou seja, a primeira caixa a entrar, independente da distância do CEP, é a primeira a sair para entrega.
        public static Caixa decidirProximaEntregaFIFO(List<Caixa> armarzem)
        {
            Caixa entregaCaixa = null;

            foreach (Caixa caixa in armarzem)
            {
                entregaCaixa = caixa;
                break;
            }

            return entregaCaixa; // Retornar próxima caixa que deverá ser entregue
        }

        // Essa seria uma resolução para o nosso problema de modelagem e simulação. Pegar dados do CEP inserido do armazém
        // E calcular a distância deste CEP até o CEP destino da caixa e entregar primeiro as caixas cujo destino é mais próximo do
        // Armazém.
        public static Caixa decidirProximaEntregaANALISECEP(List<Caixa> armazem)
        {
            Caixa entregaCaixa = armazem[0];

            // Selecionando a caixa cujo tempo do armazém até o destino é MENOR

            /**
             * ==========================[ AVISO ]==========================
             * 
             * As informações de tempo do CEP do armazém até o CEP do destino da caixa são informações verdadeiras (não foram inventadas),
             * mais detalhes sobre como e onde os dados são pegos em https://github.com/DavidAS-BR/CorreioProj/tree/main/ModSimTripTimeAPI
             **/
            foreach (Caixa caixa in armazem)
            {
                if (float.Parse(entregaCaixa.tempoTransporteSeconds) > float.Parse(caixa.tempoTransporteSeconds))
                {
                    entregaCaixa = caixa;
                }
            }

            return entregaCaixa;
        }
    }
}
