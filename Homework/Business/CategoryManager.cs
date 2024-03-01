using Homework.DataAccess.Abstracts;
using Homework.Entities;

namespace Homework.Business;

public class CategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }
}
