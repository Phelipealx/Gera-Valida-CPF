using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPFeCNPJ.Models
{
    public class PessoaFisica
    {
        public string Cpf { get; set; }

        public PessoaFisica(string cpf)
        {
            Cpf = cpf;
        }

        public PessoaFisica()
        {
        }
    }
}