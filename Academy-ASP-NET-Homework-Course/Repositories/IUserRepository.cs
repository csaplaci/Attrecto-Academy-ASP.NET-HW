using Academy_ASP_NET_Homework_Course.Data;

namespace Academy_ASP_NET_Homework_Course.Repositories
{
    public interface IUserRepository
    {
        void Create(User data);
        bool Delete(int id);
        List<User> GetAll();
        User? GetById(int id);
        User? Update(int id, User data);
    }
}