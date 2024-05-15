using Core.commands;
using Core.Domains;
using Core.Interfaces.Repository;
using Core.Responses;
using MediatR;


namespace Core.Handlers
{
    public class AddCategoryHandler : IRequestHandler<AddCategoryCommand, AddCategoryResponse>
    {
        public ICategoryRepository _categoryRepository { get; }

        public AddCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<AddCategoryResponse> Handle(AddCategoryCommand Command, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                Id = Command.Id,
                Title = Command.Title,
                CreatedDate = Command.CreatedDate
            };
            var response = await _categoryRepository.Add(category);
            var CategoryResponse = new AddCategoryResponse { Id = response };
            return CategoryResponse;


        }
    }
}
