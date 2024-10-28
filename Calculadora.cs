using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_Talentos
{
    public class Calculadora // Mude 'internal' para 'public'
    {
        private List<string> ListaHistorico;

        public Calculadora()
        {
            ListaHistorico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            ListaHistorico.Insert(0, "Res" + res);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            ListaHistorico.Insert(0, "Res" + res);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            ListaHistorico.Insert(0, "Res" + res);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;

            ListaHistorico.Insert(0, "Res" + res);
            return res;
        }

        public List<String> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }

    }
}
