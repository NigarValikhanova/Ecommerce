﻿using AutoMapper;
using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllBrandHandler : IRequestHandler<GetAllBrandsQuery, IList<BrandResponse>>
    {
        public IBrandRepository _brandRepository { get; }

        public GetAllBrandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task<IList<BrandResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brandList = await _brandRepository.GetAllBrands();
            var brandResponseList = ProductMapper.Mapper.Map<IList<ProductBrand>,IList<BrandResponse>>(brandList.ToList());
            return brandResponseList;
        }
    }
}
