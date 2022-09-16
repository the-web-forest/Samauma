using Samauma.Domain.Models;
using Samauma.UseCases.PartnersUseCases.ListPartners;

namespace Samauma.UseCases.Interfaces.Repositories
{
    public interface IPartnerRepository : IBaseRepository<Partner>
    {
        Task<Paging<Partner>> GetPartnersByFilter(ListPartnersUseCaseInput filter);
    }
}
