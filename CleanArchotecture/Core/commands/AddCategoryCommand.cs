using Core.Domains;
using Core.Responses;
using MediatR;
namespace Core.commands;

public class AddCategoryCommand : Base, IRequest<AddCategoryResponse>
{
    public string Title { get; set; }
}

