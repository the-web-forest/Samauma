using Samauma.Domain.Errors;
using Samauma.Domain.Models;
using Samauma.Helpers;
using Samauma.UseCases.Interfaces;

namespace Samauma.UseCases.PartnersUseCases.DeletePartner
{
    public class DeletePartnerUseCase : IUseCase<DeletePartnerUseCaseInput, DeletePartnerUseCaseOutput>
    {
        private readonly IPartnerRepository _partnerRepository;

        public DeletePartnerUseCase(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        public async Task<DeletePartnerUseCaseOutput> Run(DeletePartnerUseCaseInput Input)
        {
            var partner = await _partnerRepository.GetPartnerById(Input.Id);

            if (partner is null)
                throw new InvalidPartnerIdException();

            if (partner.Deleted)
                throw new PartnerAlreadyDeletedException();

            partner.Deleted = true;

            await _partnerRepository.Update(partner);

            return new DeletePartnerUseCaseOutput();
        }
    }
}
