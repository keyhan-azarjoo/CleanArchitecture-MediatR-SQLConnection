using Core.Domains;
using Core.Interfaces.Repository;
using Core.Queries;
using MediatR;

namespace Core.Handlers
{
    public class GetLatestPostHandler : IRequestHandler<GetLatestPostQuery, List<Post>>
    {
        public IPostRepository _postRepository { get; }

        public GetLatestPostHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<List<Post>> Handle(GetLatestPostQuery request, CancellationToken cancellationToken)
        {
            return await _postRepository.GetLastPosts(request.Count);
        }
    }
}
