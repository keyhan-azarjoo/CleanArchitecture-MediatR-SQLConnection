using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        public MyDbContext _MyDbContext { get; }
        public PostRepository(MyDbContext myDbContext)
        {
            _MyDbContext = myDbContext;
        }
        public async Task<List<Post>> GetLastPosts(int count)
        {
            var result = _MyDbContext.Posts
                .Select(x => new Post
                {
                    Id = x.Id,
                    Title = x.Title,
                    Content = x.Content,
                    CreatedDate = x.CreatedDate
                }).OrderByDescending(x => x.CreatedDate).Take(count).ToListAsync();

            return await result;
        }
    }
}
