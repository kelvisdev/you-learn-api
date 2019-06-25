using Microsoft.AspNetCore.Mvc;

namespace YouLearn.Api.Controllers
{
    public class UtilController
    {
        [HttpGet]
        [Route("")]
        public string Versao()
        {
            return "Seja bem vindo ao YouLearn";
        }

        [HttpGet]
        [Route("Version")]
        public string Post()
        {
            return "0.0.1";
        }
    }
}
