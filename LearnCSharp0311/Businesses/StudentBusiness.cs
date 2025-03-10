﻿using LearnCSharp0311.Entities;
using LearnCSharp0311.Interfaces;

namespace LearnCSharp0311.Businesses;

internal class StudentBusiness : IBaseBusiness<Student>
{
    List<Student> students = new List<Student>();
    public StudentBusiness()
    {
        students.Add(new Student() { FirstName = "st-fs-1", LastName= "st-ls-1"});
        students.Add(new Student() { FirstName = "st-fs-2", LastName = "st-ls-2" });
    }

    public void Add(Student item)
    {
        students.Add(item);
    }


    public List<Student> GetAll()
    {
        return students;
    }

}
