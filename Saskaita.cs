using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_08___BIBLIOTEKA
{
    public struct Saskaita
    {
        private string _siuntejas;
        private string _gavejas;
        private decimal _moketiViso;
        private string SaskaitosNumeris;

        public Saskaita(string siuntejas, string gavejas, decimal moketiViso, string saskaitosNumeris)
        {
            Siuntejas = siuntejas;
            Gavejas = gavejas;
            MoketiViso = moketiViso;
            SaskaitosNumeris = saskaitosNumeris;
        }

        public Saskaita
        public string SaskaitosNumeris { get; private set; }
        private void KurtiSaskaitosNumeri()
        {
            SaskaitosNumeris = string.Format("{NR}_2022_balandzio_07_01", //parametrai, );
        }
    }
}
