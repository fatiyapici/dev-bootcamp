using Bootcamp.DataAccess.Abstracts;
using Bootcamp.Entities;

namespace Bootcamp.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //CourseDal courseDal = new CourseDal();

        return _courseDal.GetAll();
    }
}
