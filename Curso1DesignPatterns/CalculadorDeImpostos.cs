using System;

namespace Curso1DesignPatterns
{
    public class CalculadorDeImpostos
    {
        //Maneiras erradas
        /*
        public void RealizaCalculo(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.1;
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.06;
                Console.WriteLine(iss);
            }
        }*/
        /*
        public void RealizaCalculo(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = new Icms().CalculaIcms(orcamento);
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = new Iss().CalculaIss(orcamento);
                Console.WriteLine(iss);
            }
        }
        */
        /*
        public void RealizaCalculoIcms(Orcamento orcamento)
        {
            double icms = new Icms().CalculaIcms(orcamento);
            Console.WriteLine(icms);
        }

        public void RealizaCalculoIss(Orcamento orcamento)
        {
            double iss = new Iss().CalculaIss(orcamento);
            Console.WriteLine(iss);
        }*/

        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double imp = imposto.Calcula(orcamento);
            Console.WriteLine(imp);
        }
    }
}
