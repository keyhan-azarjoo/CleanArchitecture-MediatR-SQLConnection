using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;
using Core.Interfaces.Repository;
using Core.Queries;
using MediatR;

namespace Core.Handlers
{
    public class GetAllCategoryHandler : IRequestHandler<GetAllCategoriesQuery, List<Category>>
    {
        public ICategoryRepository _categoryRepository { get; }

        public GetAllCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetAll();
        }
    }
}
