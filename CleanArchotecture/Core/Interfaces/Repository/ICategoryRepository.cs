using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;

namespace Core.Interfaces.Repository;

public interface ICategoryRepository
{
    Task<Category> GetById(int id);
    Task<List<Category>> GetAll();
    Task<int> Add(Category category);
    Task<bool> Edit(Category category);
    Task<bool> Delete(int id);

}

