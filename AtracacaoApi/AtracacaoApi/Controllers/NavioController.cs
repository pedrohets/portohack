using AtracacaoApi.Model;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Linq;

namespace AtracacaoApi.Controllers
{
    /// <summary>
    /// Informações dos navios
    /// </summary>
    [ApiController]
    [Route("Navio")]
    [OpenApiTag("Navio", Description = "Informações dos navios.")]
    public class NavioController : ControllerBase
    {
        /// <summary>
        /// Método para obter os dados dos navios
        /// </summary>
        /// <returns>Navios</returns>
        [HttpGet("Navios")]
        public IActionResult ObterNavios()
        {
            return Ok(NavioModel.ObterNavios().Select(c => new { c.Nome, c.Imo } ));
        }

        /// <summary>
        /// Recuperar dados do navio
        /// </summary>
        /// <param name="imo">Imo</param>
        /// <returns>Detalhes do Navio</returns>
        [HttpGet("{imo}/Dados")]
        public IActionResult ObterNavios(string imo)
        {
            return Ok(NavioModel.ObterNavios().Where(c => c.Imo == imo).Select(c => new { c }));
        }
    }
}
