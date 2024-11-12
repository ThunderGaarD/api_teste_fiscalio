using api_teste_fiscalio.Services;
using Microsoft.AspNetCore.Mvc;


namespace NumberToTextAPI.Controllers
{
    [Route("api/[controller]")] // rotas
    [ApiController]
    public class NumberToTextController : ControllerBase
    {
        private readonly NumberToTextService _numberToTextService;

        // Construtor que recebe o serviço injetado
        public NumberToTextController(NumberToTextService numberToTextService)
        {
            _numberToTextService = numberToTextService;
        }

        // Endpoint para converter número em texto por extenso
        [HttpGet("{number}")]
        public ActionResult<string> Get(long number)
        {
            var texto = _numberToTextService.ConvertNumberToText(number);
            return Ok(texto);  // Retorna a resposta com o texto convertido
        }
    }
}
