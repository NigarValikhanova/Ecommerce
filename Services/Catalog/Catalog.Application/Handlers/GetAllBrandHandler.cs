using AutoMapper;
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
        public IMapper _mapper { get; }

        public GetAllBrandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public async Task<IList<BrandResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brandList = await _brandRepository.GetAllBrands();
            var brandResponseList = _mapper.Map<IList<ProductBrand>,IList<BrandResponse>>(brandList.ToList());
            return brandResponseList;
        }
    }
}
