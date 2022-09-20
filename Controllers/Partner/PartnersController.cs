using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Samauma.Controllers.Partner.DTOs;
using Samauma.Domain.Errors;
using Samauma.UseCases;
using Samauma.UseCases.PartnersUseCases.ListPartners;

namespace Samauma.Controllers.Partner
{
    [ApiController]
    [Route("Partners")]
    //[Authorize]
    public class PartnersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<PartnersController> _logger;
        private readonly IUseCase<ListPartnersUseCaseInput, ListPartnersUseCaseOutput> _listPartnersUseCase;

        public PartnersController(
            IMapper mapper,
            ILogger<PartnersController> logger,
            IUseCase<ListPartnersUseCaseInput, ListPartnersUseCaseOutput> listPartnersUseCase
        )
        {
            _mapper = mapper;
            _listPartnersUseCase = listPartnersUseCase;
            _logger = logger;
        }

        /*[HttpPost]
        public async Task<ObjectResult> CreatePartner([FromBody] CreatePartnerInput Input/)
        {
            _logger.LogInformation("Create partner has called => {Name}", Input.Name);

            try
            {
                var Data = await _createPartnerUseCase.Run(new CreatePartnerUseCaseInput
                {
                    
                });

                return new ObjectResult( new { });
            }
            catch (BaseException e)
            {
                return new BadRequestObjectResult(e.Data);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }*/

        /*[HttpPut]
        public async Task<ObjectResult> UpdatePartner([FromBody] UpdatePartnerInput Input)
        {
            _logger.LogInformation("Update partner has called => {Id}", Input.Id);
            
            try
            {
                var Data = await _updatePartnerUseCase.Run(new UpdatePartnerUseCaseInput
                {
                    
                });

                return new ObjectResult(Data);
            }
            catch (BaseException e)
            {
                return new BadRequestObjectResult(e.Data);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }*/

        [HttpGet("List")]
        public async Task<ObjectResult> GetPartners([FromQuery] PartnersSearchInput input)
        {
            _logger.LogInformation("Get partner list has called");

            try
            {
                var Data = await _listPartnersUseCase.Run(_mapper.Map<ListPartnersUseCaseInput>(input));
                /*var Data = await _listPartnersUseCase.Run(new ListPartnersUseCaseInput
                {
                    Name = input.Name,
                    Code = input.Code,
                    Email = input.Email,
                    Url = input.Url,
                    Skip = input.Skip,
                    Take = input.Take,
                    RequiredTotal = input.RequiredTotal
                });*/

                return new ObjectResult(Data);
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

        /*[HttpGet("{Id}")]
        public async Task<ObjectResult> GetPartnerById(string Id)
        {
            _logger.LogInformation("Get partner by identificator has called => {Id}", Id);
            try
            {
                var Data = await _getPartnerByIdUseCase.Run(new GetPartnerByIdUseCaseInput
                {
                    
                });

                return new ObjectResult(Data);
            }
            catch (BaseException e)
            {
                return new BadRequestObjectResult(e.Data);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }*/

                /*[HttpDelete("{Id}")]
                public async Task<ObjectResult> DeletePartner(string Id)
                {
                    _logger.LogInformation("Delete partner has called => {Id}", Id);

                    try
                    {
                        var Data = await _deletePartnerUseCase.Run(new DeletePartnerUseCaseInput
                        {
                            Id = Id
                        });

                        return new ObjectResult(Data);
                    }
                    catch (BaseException e)
                    {
                        return new BadRequestObjectResult(e.Data);
                    }
                    catch (Exception e)
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
                    }
                }*/
            }
}
