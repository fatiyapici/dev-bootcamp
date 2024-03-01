using Homework.DataAccess.Abstracts;
using Homework.Entities;

namespace Homework.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {
        Category programming = new Category();
        programming.Id = 1;
        programming.Name = "Programming";

        Category technology = new Category();
        technology.Id = 2;
        technology.Name = "Java";

        categories = new List<Category> { programming, technology };
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Update(Category category)
    {
        var categoryToUpdate = categories.FirstOrDefault(i => i.Id == category.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.Name = category.Name;
        }
    }

    public void Delete(Category category)
    {
        var categoryToDelete = categories.FirstOrDefault(i => i.Id == category.Id);
        if (categoryToDelete != null)
        {
            categories.Remove(categoryToDelete);
        }
    }
}
