using System.Security.Cryptography.X509Certificates;
using Core.Domains;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using CategoryEntity = Infrastructure.Data.Entities.Category;
using CategoryDomain = Core.Domains.Category;

namespace Infrastructure.Data.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        public MyDbContext _myDbContext { get; }

        public CategoryRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<CategoryDomain> GetById(int id)
        {
            var item = _myDbContext.Categories.Select(c => new CategoryDomain
            {
                Id = c.Id,
                Title = c.Title,
                CreatedDate = c.CreatedDate
            }).FirstOrDefaultAsync(x => x.Id == id);
            if (item == null)
            {
                throw new Exception("Not Found");
            }
            return await item;
        }

        public async Task<List<CategoryDomain>> GetAll()
        {
            return await _myDbContext.Categories.Select(x => new CategoryDomain
            {
                Title = x.Title,
                CreatedDate = x.CreatedDate,
                Id = x.Id
            }).ToListAsync();
        }

        public async Task<int> Add(CategoryDomain category)
        {
            var dbModle = new CategoryEntity
            {
                CreatedDate = DateTime.UtcNow,
                Title = category.Title
            };
            await _myDbContext.Categories.AddAsync(dbModle);
            await _myDbContext.SaveChangesAsync();

            return dbModle.Id;
        }

        public async Task<bool> Edit(CategoryDomain category)
        {
            try
            {

                var found = await GetCategory(category.Id);
                found.Title = category.Title;

                _myDbContext.Categories.Update(found);
                await _myDbContext.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var found = await GetCategory(id);
                _myDbContext.Remove(found);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

  
        }
        private async Task<CategoryEntity> GetCategory(int id)
        {
            var item = await _myDbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (item == null)
            {
                throw new Exception("Not Found");
            }
            return item;
        }
    }
}
