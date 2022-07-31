using Microsoft.AspNetCore.Mvc;

namespace AtracacaoApi.Controllers
{
    /// <summary>
    /// Informações dos navios
    /// </summary>
    [ApiController]
    [Route("Navio")]
    public class NavioController : ControllerBase
    {
        /// <summary>
        /// Método para obter os dados do navio
        /// </summary>
        /// <returns>Dados do navio</returns>
        [HttpGet("DadosNavio")]
        public IActionResult ObterDadosNavio()
        {
            var retorno = new
            {
                Nome = "CAP SAN LORENZO",
                Imo = "9622227",
                Bandeira = "Denmark [DK]",
                TipoNavio = "Container Ship"
            };
            return Ok(retorno);
        }
    }
}
