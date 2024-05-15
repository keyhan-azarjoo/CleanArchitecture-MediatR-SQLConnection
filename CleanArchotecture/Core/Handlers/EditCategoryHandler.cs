using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.commands;
using Core.Domains;
using Core.Interfaces.Repository;
using Core.Responses;
using MediatR;

namespace Core.Handlers
{
    public class EditCategoryHandler : IRequestHandler<EditCategoryCommand,EditCategoryResponse>
    {
        public ICategoryRepository _categoryRepository { get; }

        public EditCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<EditCategoryResponse> Handle(EditCategoryCommand request, CancellationToken cancellationToken)
        {

            var category = new Category
            {
                Id = request.Id,
                Title = request.Title
            };
            var response = await _categoryRepository.Edit(category);
            var categoryResponse = new EditCategoryResponse
            {
                IsChanged = response
            };
            return categoryResponse;
        }
    }
}
