using System;

namespace Curso1DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando e usando a classe que foi feita de maneira errada - Pouco coesa e complicada, cheia de if's
            /*
            Orcamento orcamento = new Orcamento(500.00);
            CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();
            calculadorDeImpostos.RealizaCalculo(orcamento, "ICMS");
            calculadorDeImpostos.RealizaCalculo(orcamento, "ISS");
            */

            IImposto iss = new Iss();
            IImposto icms = new Icms();

            Orcamento orcamento = new Orcamento(500.00);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);

            calculador.RealizaCalculo(orcamento, icms);

            CalculadorDeDescontos calculadorDesconto = new CalculadorDeDescontos();

            orcamento.AdicionarItem(new Item("Caneta", 500));
            orcamento.AdicionarItem(new Item("Lapis", 500));

            double desconto = calculadorDesconto.Calcula(orcamento);
            Console.WriteLine(desconto);


            Console.ReadKey();
        }
    }
}
