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
        public string SaskaitosNumeris;

        public Saskaita(string siuntejas, string gavejas, decimal moketiViso)
        {
            _siuntejas = siuntejas;
            _gavejas = gavejas;
            _moketiViso = moketiViso;
            SaskaitosNumeris = string.Empty;
            SaskaitosNumeris = KurtiSaskaitosNumeri();
        }

        public string SaskaitosNumeris { get; private set; }
              
        private void KurtiSaskaitosNumeri()
        {
            SaskaitosNumeris = string.Format("{}_{}_{}_{}_{}", //parametrai, );
        }
    }
}
