using Samauma.Domain.Models;
using Samauma.UseCases.Interfaces.Repositories;
using Samauma.UseCases.PartnersUseCases.ListPartners;

namespace Samauma.UseCases.Interfaces
{
    public interface IPartnerRepository : IBaseRepository<Partner>
    {
        Task<Paging<Partner>> GetPartnersByFilter(ListPartnersUseCaseInput filter);
        Task<bool> VerifyPartnerEmailExistence(string email);
        Task<int> GetNextCode();
    }
}
