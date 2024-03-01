using Homework.DataAccess.Abstracts;
using Homework.Entities;

namespace Homework.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course cs = new Course();
        cs.Id = 1;
        cs.Name = "C#";
        cs.Description = ".NET 8";
        cs.Price = 0;

        Course java = new Course();
        java.Id = 2;
        java.Name = "Java";
        java.Description = "Java 17";
        java.Price = 10;

        courses = new List<Course> { cs, java };
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Update(Course course)
    {
        var courseToUpdate = courses.FirstOrDefault(i => i.Id == course.Id);
        if (courseToUpdate != null)
        {
            courseToUpdate.Name = course.Name;
        }
    }

    public void Delete(Course course)
    {
        var courseToDelete = courses.FirstOrDefault(i => i.Id == course.Id);
        if (courseToDelete != null)
        {
            courses.Remove(courseToDelete);
        }
    }
}
