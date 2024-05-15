using Core.Domains;
using Core.Responses;
using MediatR;

namespace Core.commands
{
    public class EditCategoryCommand : Base, IRequest<EditCategoryResponse>
    {
        public string Title { get; set; }
    }
}
