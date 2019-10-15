using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entity;
using Api.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class taxaJurosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetTaxa([FromServices] ICorrecaoService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Correcao correcao = new Correcao();
                Task<Correcao> Taxa = service.GetTaxa(correcao);
                Taxa.Wait();
                return Ok(Taxa.Result.Taxa.ToString());
            }
            catch (System.Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
