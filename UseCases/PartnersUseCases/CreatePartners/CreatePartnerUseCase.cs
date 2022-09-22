using AutoMapper;
using Samauma.Domain.Errors;
using Samauma.Domain.Models;
using Samauma.UseCases.Interfaces;
using Samauma.Util;

namespace Samauma.UseCases.PartnersUseCases.CreatePartners
{
    public class CreatePartnerUseCase : IUseCase<CreatePartnerUseCaseInput, CreatePartnerUseCaseOutput>
    {
        private readonly IMapper _mapper;
        private readonly IPartnerRepository _partnerRepository;
        private readonly ITreeRepository _treeRepository;

        public CreatePartnerUseCase(
            IMapper mapper,
            IPartnerRepository partnerRepository,
            ITreeRepository treeRepository)
        {
            _mapper = mapper;
            _partnerRepository = partnerRepository;
            _treeRepository = treeRepository;
        }

        public async Task<CreatePartnerUseCaseOutput> Run(CreatePartnerUseCaseInput input)
        {
            if (!RegexUtilities.IsValidEmailAdress(input.Email))
                throw new InvalidPartnerEmailException();

            if (!RegexUtilities.IsValidUrl(input.Url))
                throw new InvalidPartnerUrlException();

            if (!RegexUtilities.IsValidPassword(input.Password))
                throw new InvalidPartnerPasswordException();

            if (await VerifyEmailExists(input.Email))
                throw new EmailAlreadyRegisteredException();

            if (!RegexUtilities.IsValidMongoObjectId(input.Tree))
                throw new InvalidTreeObjectIdException();

            if (!await VerifyTreeExists(input.Tree))
                throw new InvalidTreeIdException();

            var partner = _mapper.Map<Partner>(input);
            partner.Code = await GetNextCode();

            await _partnerRepository.Create(partner);
            return new CreatePartnerUseCaseOutput();
        }

        private async Task<int> GetNextCode()
            => await _partnerRepository.GetNextCode();

        private async Task<bool> VerifyEmailExists(string email)
            => await _partnerRepository.VerifyPartnerEmailExistence(email);

        private async Task<bool> VerifyTreeExists(string objectId)
            => await _treeRepository.VerifyTreeExistenceById(objectId);
    }
}
