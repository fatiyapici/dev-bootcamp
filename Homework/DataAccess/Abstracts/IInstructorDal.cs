using Homework.Entities;

namespace Homework.DataAccess.Abstracts;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(Instructor instructor);
}
