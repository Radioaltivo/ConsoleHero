using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHero
{
    public class Nota
    {
        public int frequencia;
        public int duracao;
        public int corda;
        public char tecla;

        public Nota(int novafreq, int novaduracao, int novacorda, char novatecla)
        {
            frequencia = novafreq;
            tecla = novatecla;
            corda = novacorda;
            duracao = novaduracao;
        }
    }
}
