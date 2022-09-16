﻿using MongoDB.Driver;
using Samauma.Domain.Models;
using Samauma.UseCases.Interfaces.Repositories;
using Samauma.UseCases.PartnersUseCases.ListPartners;

namespace Samauma.External.Repositories
{
    public class PartnerRepository : BaseRepository<Partner>, IPartnerRepository
    {
        public PartnerRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        { }

        public async Task<Paging<Partner>> GetPartnersByFilter(ListPartnersUseCaseInput filter)
        {
            var query = _collection
                .Aggregate();

            if (!String.IsNullOrEmpty(filter.Name))
                query = query
                    .Match(partner => !String.IsNullOrEmpty(partner.Name) && partner.Name.ToLower().Contains(filter.Name.Trim().ToLower()));

            if (!String.IsNullOrEmpty(filter.Email))
                query = query
                    .Match(partner => !String.IsNullOrEmpty(partner.Email) && partner.Email.ToLower().Contains(filter.Email.Trim().ToLower()));

            if (!String.IsNullOrEmpty(filter.Url))
                query = query
                    .Match(partner => !String.IsNullOrEmpty(partner.Url) && partner.Url.ToLower().Contains(filter.Url.Trim().ToLower()));

            if (filter.Code is not null && filter.Code > 0)
                query = query
                    .Match(partner => partner.Code == filter.Code);

            query = query
                .SortBy(partner => partner.Name);

            long? total = null;
            if (filter.RequiredTotal == true)
                total = query.Count().FirstOrDefault().Count;

            if (filter.Skip is not null)
                query = query
                    .Skip(filter.Skip ?? 0);

            if (filter.Take is not null)
                query = query
                    .Limit(filter.Take ?? 0);

            return await query
                .ToListAsync()
                .ContinueWith(partners => new Paging<Partner>
                {
                    Data = partners.Result,
                    TotalCount = total
                });
        }
    }
}
