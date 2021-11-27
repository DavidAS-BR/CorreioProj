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
        private string _horastrasporte; 
        private string _prioridade;

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

        public string prioridade
        {
            get
            {
                return _prioridade;
            }

            set
            {
                _prioridade = value;
            }
        }

        public string horastrasporte
        {
            get
            {
                return _horastrasporte;
            }

            set
            {
                _horastrasporte = value;
            }
        }
    }
}
