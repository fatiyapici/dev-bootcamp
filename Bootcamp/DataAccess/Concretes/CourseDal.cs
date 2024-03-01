﻿using Bootcamp.DataAccess.Abstracts;
using Bootcamp.Entities;

namespace Bootcamp.DataAccess.Concretes;

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
        // DbOperations...
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
