using BaseBackend.Entities;
using BaseBackend.Interfaces;
using Newtonsoft.Json;

namespace BaseBackend.Businesses
{
    public class CourseBusiness : IBaseBusiness<Course>
    {
        public bool Add(Course item)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            string jsonDataStrFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "CourseData.json");
            string jsonDataStr = File.ReadAllText(jsonDataStrFilePath);
            List<Course> courses = JsonConvert.DeserializeObject<List<Course>>(jsonDataStr);
            return courses;
        }

        public bool Update(Course item)
        {
            throw new NotImplementedException();
        }

    }
}
