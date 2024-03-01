using Homework.DataAccess.Abstracts;
using Homework.Entities;

namespace Homework.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;

    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.Id = 1;
        instructor1.Name = "Ahmet";

        Instructor instructor2 = new Instructor();
        instructor2.Id = 2;
        instructor2.Name = "Mehmet";

        instructors = new List<Instructor> { instructor1, instructor2 };
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        var instructorToUpdate = instructors.FirstOrDefault(i => i.Id == instructor.Id);
        if (instructorToUpdate != null)
        {
            instructorToUpdate.Name = instructor.Name;
        }
    }

    public void Delete(Instructor instructor)
    {
        var instructorToDelete = instructors.FirstOrDefault(i => i.Id == instructor.Id);
        if (instructorToDelete != null)
        {
            instructors.Remove(instructorToDelete);
        }
    }
}
