using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso1DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            //Primeira tentativa: Errada
            /*
            //1a.Regra: mais de 5 itens
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return 0;

            //Segunda Tentativa: Também errada
            double desconto = new DescontoPorCincoItens().Desconta(orcamento);
            if (desconto == 0)
            {
                desconto = new DescontoPorMaisDeQuinhetosReais().Desconta(orcamento);
            }
            */

            //Maneira correta usando chain of responsability
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhetosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;


            return d1.Desconta(orcamento);
        }
    }
}
