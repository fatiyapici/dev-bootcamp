using Homework.Entities;

namespace Homework.DataAccess.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}
