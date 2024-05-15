using Core.commands;
using Core.Interfaces.Repository;
using Core.Responses;
using MediatR;

namespace Core.Handlers
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, DeleteCategoryResponse>
    {
        public ICategoryRepository _categoryRepository { get; }

        public DeleteCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<DeleteCategoryResponse> Handle(DeleteCategoryCommand command, CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.Delete(command.Id);
            return new DeleteCategoryResponse { IsDeleted = result };

        }
    }
}
