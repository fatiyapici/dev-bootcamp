using Bootcamp.Entities;

namespace Bootcamp.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
}
