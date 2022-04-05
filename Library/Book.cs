using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public struct Book
    {
        //deklaruoti field'ai
        private string _name;
        private string _id;

        public string Name //Tampa Properties nebe FIeld
        {
            get // paimam
            {
                return _name;
            }
            private set // uzsetinam verte >> darasius PRO=IVATE, neleis uzsetint   
            {
                _name = value;
                //galim daryt validacija per koki FOR ar panasiai viduj
            }
        }
        public string id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }
        public string LocalId { get; private set; } // naujoviskas GET SET variantas
        public Book(string name, string id)
        {
            _name = name;
            _id = id;
            LocalId = string.Empty;
            CreateLocalId();
        }
        //private void setValue() //PVZ
        //{
        //    Name = "Belekas"; // per cia galim prisetint veiksme, net jei settet PRIVATE, jis atsiranda settet ties VALUE
        //}
        private void CreateLocalId()
        {
            LocalId = string.Format("{0}_{1}", Name, id);
        }
    }
}
