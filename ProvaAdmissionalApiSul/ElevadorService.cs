using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAdmissionalApiSul
{
    public class ElevadorService : IElevadorService
    {

        List<Informacao> informacao;
        ReadData readData;
        string fileToRead;

        public ElevadorService()
        {
            informacao = new List<Informacao>();
            readData = new ReadData();
            fileToRead = "input.json";

        }

        public List<int> andarMenosUtilizado()
        {
            Dictionary<int, int> andares = new Dictionary<int, int>();
            List<int> andaresMenosUsados = new List<int>();

            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }

            for (var i = 0; i <= 15; i++)
            {
                andares.Add(i, 0);
            }


            foreach (var info in informacao)
            {
                andares[info.andar]++;
            }

            var ordered = andares.OrderBy(x => x.Value).ToList();

            andaresMenosUsados.AddRange(ordered.Where(x => x.Value == ordered[0].Value).Select(X => X.Key).ToList());



            return andaresMenosUsados;
        }

        public List<char> elevadorMaisFrequentado()
        {
            Dictionary<char, int> elevador = new Dictionary<char, int>();
            List<char> elevadoresMaisFrequentados = new List<char>();

            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }

            for (var i = 65; i <= 69; i++)
            {
                elevador.Add((char)i, 0);
            }


            foreach (var info in informacao)
            {
                elevador[info.elevador]++;
            }

            var ordered = elevador.OrderByDescending(x => x.Value).ToList();

            elevadoresMaisFrequentados.AddRange(ordered.Where(x => x.Value == ordered[0].Value).Select(x => x.Key).ToList());

            return elevadoresMaisFrequentados;
        }

        public List<char> elevadorMenosFrequentado()
        {
            Dictionary<char, int> elevador = new Dictionary<char, int>();
            List<char> elevadoresMenosFrequentados = new List<char>();

            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }

            for (var i = 65; i <= 69; i++)
            {
                elevador.Add((char)i, 0);
            }


            foreach (var info in informacao)
            {
                elevador[info.elevador]++;
            }

            var ordered = elevador.OrderBy(x => x.Value).ToList();

            elevadoresMenosFrequentados.AddRange(ordered.Where(x => x.Value == ordered[0].Value).Select(x => x.Key).ToList());

            return elevadoresMenosFrequentados;
        }

        public float percentualDeUsoElevadorA()
        {
            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }
            float usoTotal = informacao.Count;
            var infoElevadorA = informacao.Where(x => x.elevador == 'A').ToList();
            float percentUsadoElevadorA = (infoElevadorA.Count * 100) / usoTotal;
            string formattedFloat = percentUsadoElevadorA.ToString("N2");
            percentUsadoElevadorA = float.Parse(formattedFloat);
            return percentUsadoElevadorA;
        }

        public float percentualDeUsoElevadorB()
        {
            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }
            float usoTotal = informacao.Count;
            var infoElevadorB = informacao.Where(x => x.elevador == 'B').ToList();
            float percentUsadoElevadorB = (infoElevadorB.Count * 100) / usoTotal;
            string formattedFloat = percentUsadoElevadorB.ToString("N2");
            percentUsadoElevadorB = float.Parse(formattedFloat);
            return percentUsadoElevadorB;
        }

        public float percentualDeUsoElevadorC()
        {
            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }
            float usoTotal = informacao.Count;
            var infoElevadorC = informacao.Where(x => x.elevador == 'C').ToList();
            float percentUsadoElevadorC = (infoElevadorC.Count * 100) / usoTotal;
            string formattedFloat = percentUsadoElevadorC.ToString("N2");
            percentUsadoElevadorC = float.Parse(formattedFloat);
            return percentUsadoElevadorC;
        }

        public float percentualDeUsoElevadorD()
        {
            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }
            float usoTotal = informacao.Count;
            var infoElevadorD = informacao.Where(x => x.elevador == 'D').ToList();
            float percentUsadoElevadorD = (infoElevadorD.Count * 100) / usoTotal;
            string formattedFloat = percentUsadoElevadorD.ToString("N2");
            percentUsadoElevadorD = float.Parse(formattedFloat);
            return percentUsadoElevadorD;
        }

        public float percentualDeUsoElevadorE()
        {
            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }
            float usoTotal = informacao.Count;
            var infoElevadorE = informacao.Where(x => x.elevador == 'E').ToList();
            float percentUsadoElevadorE = (infoElevadorE.Count * 100) / usoTotal;
            string formattedFloat = percentUsadoElevadorE.ToString("N2");
            percentUsadoElevadorE = float.Parse(formattedFloat);
            return percentUsadoElevadorE;
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            Dictionary<char, int> turnos = new Dictionary<char, int>();
            List<char> periodoElevadoresMaisFrequentados = new List<char>();


            turnos.Add('M', 0);
            turnos.Add('V', 0);
            turnos.Add('N', 0);
            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }

            var elevadoresMaisFrequentados = this.elevadorMaisFrequentado();

            foreach (var elevador in elevadoresMaisFrequentados)
            {
                turnos['M'] = 0;
                turnos['V'] = 0;
                turnos['N'] = 0;
                var result = informacao.Where(x => x.elevador == elevador).ToList();
                foreach (var info in result)
                {
                    turnos[info.turno]++;
                }
                var ordered = turnos.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ToList();
                periodoElevadoresMaisFrequentados.AddRange(ordered.Where(x => ordered[0].Value == x.Value).Select(x => x.Key));
            }
            return periodoElevadoresMaisFrequentados;

        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            Dictionary<char, int> elevadores = new Dictionary<char, int>();
            Dictionary<char, int> turnos = new Dictionary<char, int>();
            List<char> periodoMaiorUtilizacaoConjuntoElevadores = new List<char>();
            for (var i = 65; i <= 69; i++)
            {
                elevadores.Add((char)i, 0);
            }

            turnos.Add('M', 0);
            turnos.Add('V', 0);
            turnos.Add('N', 0);

            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }

            var result = informacao.GroupBy(x => x.turno);

            foreach (var group in result)
            {
                elevadores.Clear();
                for (var i = 65; i <= 69; i++)
                {
                    elevadores.Add((char)i, 0);
                }
                foreach (var item in group)
                {
                    elevadores[item.elevador]++;
                    if (elevadores.All(x => x.Value > 0))
                    {
                        turnos[group.Key]++;
                        elevadores.Clear();
                        for (var i = 65; i <= 69; i++)
                        {
                            elevadores.Add((char)i, 0);
                        }
                    }

                }
            }
            var ordered = turnos.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ToList();
            periodoMaiorUtilizacaoConjuntoElevadores.AddRange(ordered.Where(x => ordered[0].Value == x.Value).Select(x => x.Key));
            return periodoMaiorUtilizacaoConjuntoElevadores;
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            Dictionary<char, int> turnos = new Dictionary<char, int>();
            List<char> periodoElevadoresMenosFrequentados = new List<char>();


            turnos.Add('M', 0);
            turnos.Add('V', 0);
            turnos.Add('N', 0);
            if (informacao.Count == 0)
            {
                informacao = readData.readJsonFile(fileToRead);
            }

            var elevadoresMenosFrequentados = this.elevadorMenosFrequentado();

            foreach (var elevador in elevadoresMenosFrequentados)
            {
                turnos['M'] = 0;
                turnos['V'] = 0;
                turnos['N'] = 0;
                var result = informacao.Where(x => x.elevador == elevador).ToList();
                foreach (var info in result)
                {
                    turnos[info.turno]++;
                }
                var ordered = turnos.Where(x => x.Value > 0).OrderBy(x => x.Value).ToList();

                periodoElevadoresMenosFrequentados.AddRange(ordered.Where(x => ordered[0].Value == x.Value).Select(x => x.Key));


            }
            return periodoElevadoresMenosFrequentados;
        }
    }
}
