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
    [RoutePrefix("api/pessoafisica")]
    public class PessoaFisicaController : ApiController
    {
        //api/PessoaFisica
        public HttpResponseMessage Get()
        {
            var pessoas = PessoaFisicaContexto.ConsultarTodos();

            return Request.CreateResponse(HttpStatusCode.OK, pessoas);
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] PessoaFisica pessoa)
        {
            PessoaFisicaContexto.Add(pessoa);

            return Request.CreateResponse(HttpStatusCode.OK, PessoaFisicaContexto.ConsultarTodos());
 
        }
    }
}
