using Core.Domains;
using Core.Responses;
using MediatR;

namespace Core.commands;
public class DeleteCategoryCommand : Base, IRequest<DeleteCategoryResponse>;
