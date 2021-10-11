using System;
using System.Collections.Generic;
using System.Text;

namespace CorreioProj
{
    class Caixa
    {
        private int _id;
        private string _cep;
        private string _tamanhoCaixa;

        public string CEP
        {
            get
            {
                return _cep;
            }

            set
            {
                _cep = value;
            }
        }

        public string tamanhoCaixa
        {
            get
            {
                return _tamanhoCaixa;
            }

            set
            {
                _tamanhoCaixa = value;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
    }
}
