using LearnCSharp0311.Entities;
using LearnCSharp0311.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp0311.Businesses
{
    internal class CourseBusiness : IBaseBusiness<Course>
    {
        public void Add(Course item)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            Course course = new Course();
            course.CourseType = Enums.CourseType.DEVELOPMENT;

            throw new NotImplementedException();
        }
    }
}
