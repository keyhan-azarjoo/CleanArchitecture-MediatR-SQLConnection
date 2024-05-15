using Core.Domains;
using MediatR;

namespace Core.Queries;

public class GetAllCategoriesQuery : IRequest<List<Category>>;

