using Academy_ASP_NET_Homework_Course.Data;

namespace Academy_ASP_NET_Homework_Course.Repositories
{
    public interface ICourseRepository
    {
        void Create(Course data);
        bool Delete(int id);
        List<Course> GetAll();
        Course? GetById(int id);
        Course? Update(int id, Course data);
    }
}