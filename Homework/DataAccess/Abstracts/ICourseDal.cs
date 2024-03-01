using Homework.Entities;

namespace Homework.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}
