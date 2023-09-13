using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAdmissionalApiSul
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ElevadorService elevador = new ElevadorService();
            var andarMenosUtilizado = elevador.andarMenosUtilizado();
            var elevadorMaisFrequentado = elevador.elevadorMaisFrequentado();
            var elevadorMenosFrequentado = elevador.elevadorMenosFrequentado();
            var periodoMenosFrequentadoElevador = elevador.periodoMenorFluxoElevadorMenosFrequentado();
            var periodoMaisFrequentadoElevador = elevador.periodoMaiorFluxoElevadorMaisFrequentado();
            var periodoMaiorUtilizacaoConjuntoElevadores = elevador.periodoMaiorUtilizacaoConjuntoElevadores();
            int count = 1;
            
            Console.Write("Andar(es) menos utilizado(s): ");

            

            foreach (var info in andarMenosUtilizado)
            {
                Console.Write(info);
                if (count < andarMenosUtilizado.Count)
                {
                    Console.Write("-");
                }
                count++;
            }

            Console.WriteLine("");

            Console.Write("Elevador(es) mais frequentado(s): ");
            
            foreach (var info in elevadorMaisFrequentado)
            {
                Console.Write(info);
                if (count < elevadorMaisFrequentado.Count)
                {
                    Console.Write("-");
                }
                count++;
            }
            Console.WriteLine("");
            count = 1;
            Console.Write("Elevador(es) menos frequentado(s): ");
            
            foreach (var info in elevadorMenosFrequentado) {
                Console.Write(info);
                if (count < elevadorMenosFrequentado.Count)
                {
                    Console.Write("-");
                }
                count++;
            }
           
            Console.WriteLine("");
            Console.WriteLine("Percentual de uso elevador A: " + elevador.percentualDeUsoElevadorA() + "%");
            Console.WriteLine("Percentual de uso elevador B: " + elevador.percentualDeUsoElevadorB() + "%");
            Console.WriteLine("Percentual de uso elevador C: " + elevador.percentualDeUsoElevadorC() + "%");
            Console.WriteLine("Percentual de uso elevador D: " + elevador.percentualDeUsoElevadorD() + "%");
            Console.WriteLine("Percentual de uso elevador E: " + elevador.percentualDeUsoElevadorE() + "%");
           

            Console.Write("Períodos dos elevadores menos frequentados: ");
            count = 1;
            foreach (var info in periodoMenosFrequentadoElevador) {
                Console.Write(info);
                if (count < periodoMenosFrequentadoElevador.Count) {
                    Console.Write("-");
                }
                count++;
            }
            count = 1;
            Console.WriteLine("");
            Console.Write("Períodos dos elevadores mais frequentados: ");
            foreach (var info in periodoMaisFrequentadoElevador)
            {
                Console.Write(info);
                if (count < periodoMaisFrequentadoElevador.Count)
                {
                    Console.Write("-");
                }
                count++;
            }

            count = 1;
            Console.WriteLine("");
            Console.Write("Período(s) de maior uso do conjunto de elevadores: ");
            foreach (var info in periodoMaiorUtilizacaoConjuntoElevadores) {
                Console.Write(info);
                if (count < periodoMaiorUtilizacaoConjuntoElevadores.Count)
                {
                    Console.Write("-");
                }
                count++;
            }


            Console.ReadKey();





        }
    }
}
