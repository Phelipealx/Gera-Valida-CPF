using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPFeCNPJ.Models
{
    public class PessoaJuridica
    {
        public string Cnpj { get; set; }

        public PessoaJuridica(string cnpj)
        {
            Cnpj = cnpj;
        }

        public PessoaJuridica() { }
    }
}