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
    [OpenApiTag("Viagem", Description = "Informações das viagenss.")]
    public class ViagemController : ControllerBase
    {
        /// <summary>
        /// Método para obter os dados dos navios
        /// </summary>
        /// <returns>Navios</returns>
        [HttpGet("Viagem")]
        public IActionResult ObterViagens()
        {
            return Ok(ViagemModel.ObterViagens().Select(c => new { c.Numero, c.Operador, c.Berco, c.Navio }));
        }

        /// <summary>
        /// Recuperar dados da viagem
        /// </summary>
        /// <param name="numero">numero</param>
        /// <returns>Detalhes do Navio</returns>
        [HttpGet("{numero}")]
        public IActionResult ObterViagem(string numero)
        {
            return Ok(ViagemModel.ObterViagens().Where(c => c.Numero == numero).Select(c => new { c }));
            //return Ok(NavioModel.ObterNavios().Where(c => c.Imo == imo).Select(c => new { c }));
        }

        /// <summary>
        /// Recuperar dados do ETB
        /// </summary>
        /// <param name="numero">numero</param>
        /// <returns>ETB</returns>
        [HttpGet("{numero}/ETB")]
        public IActionResult ObterETB(string numero)
        {
            return Ok(ViagemModel.ObterViagens().Where(c => c.Numero == numero).Select(c => new { c.ETB, c.Operador, c.Berco }));
        }

        /// <summary>
        /// Recuperar dados do ETS
        /// </summary>
        /// <param name="numero">numero</param>
        /// <returns>ETS</returns>
        [HttpGet("{numero}/ETS")]
        public IActionResult ObterETS(string numero)
        {
            return Ok(ViagemModel.ObterViagens().Where(c => c.Numero == numero).Select(c => new { c.ETS, c.Operador, c.Berco }));
        }

        /// <summary>
        /// Recuperar dados do abertura
        /// </summary>
        /// <param name="numero">numero</param>
        /// <returns>Abertura Gate</returns>
        [HttpGet("{numero}/AberturaGate")]
        public IActionResult ObterAbertura(string numero)
        {
            return Ok(ViagemModel.ObterViagens().Where(c => c.Numero == numero).Select(c => new { c.AberturaGate, c.Operador, c.Berco }));
        }
    }
}
