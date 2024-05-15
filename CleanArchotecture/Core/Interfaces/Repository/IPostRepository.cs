using Core.Domains;

namespace Core.Interfaces.Repository;

public interface IPostRepository
{
    Task<List<Post>> GetLastPosts(int count);
}

