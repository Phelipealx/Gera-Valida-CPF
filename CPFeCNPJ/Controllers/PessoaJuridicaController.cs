using CPFeCNPJ.Models;
using CPFeCNPJ.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CPFeCNPJ.Controllers
{
    [RoutePrefix("api/pessoajuridica")]
    public class PessoaJuridicaController : ApiController
    {
        //api/PessoaJuridica
        public HttpResponseMessage Get()
        {
            var pessoas = PessoaJuridicaContexto.ConsultarTodos();

            return Request.CreateResponse(HttpStatusCode.OK, pessoas);
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] PessoaJuridica pessoa)
        {
            PessoaJuridicaContexto.Add(pessoa);

            return Request.CreateResponse(HttpStatusCode.OK, PessoaJuridicaContexto.ConsultarTodos());

        }
    }
}
