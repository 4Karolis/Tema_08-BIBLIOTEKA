using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_08___BIBLIOTEKA
{
    public struct Mokinys
    {
        public List<int> Trimestras1;
        public List<int> Trimestras2;
        public List<int> Trimestras3;

        public Mokinys(List<int> trimestras1, List<int> trimestras2, List<int> trimestras3)
        {
            Trimestras1 = trimestras1;
            Trimestras2 = trimestras2;
            Trimestras3 = trimestras3;
        }

        public int PirmoTrimestroVidurkis(List<int> Trimestras1)
        {
            int suma = 0;
            for (int i = 0; i < Trimestras1.Count; i++)
            {
                suma += suma;
            }
            int vidurkis = suma / Trimestras1.Count;
            return vidurkis;
        }
    }
}
