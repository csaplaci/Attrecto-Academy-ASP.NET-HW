using Academy_ASP_NET_Homework_Course.Data;

namespace Academy_ASP_NET_Homework_Course.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public User? GetById(int id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }
        public void Create(User data)
        {
            _context.Users.Add(data);
            _context.SaveChanges();
        }
        public User? Update(int id, User data)
        {
            var user = _context.Users.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                user.FirstName = data.FirstName;
                user.LastName = data.LastName;
                _context.SaveChanges();
                return user;
            }
            return null;
        }
        public bool Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
