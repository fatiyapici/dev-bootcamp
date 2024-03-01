using Homework.DataAccess.Abstracts;
using Homework.Entities;

namespace Homework.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }
}
