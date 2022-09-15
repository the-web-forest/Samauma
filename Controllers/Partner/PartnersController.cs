using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Samauma.Domain.Errors;

namespace Samauma.Controllers.Partner
{
    [ApiController]
    [Route("Partners")]
    [Authorize]
    public class PartnersController : ControllerBase
    {
        private readonly ILogger<PartnersController> _logger;

        public PartnersController(
            ILogger<PartnersController> logger
            )
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ObjectResult> CreatePartner(/*[FromBody] CreatePartnerInput Input*/)
        {
            //_logger.LogInformation("Create partner Called => {Name}", Input.Name);

            try
            {
                return new ObjectResult(/*Data*/ new { });
            }
            catch (BaseException e)
            {
                return new BadRequestObjectResult(e.Data);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
