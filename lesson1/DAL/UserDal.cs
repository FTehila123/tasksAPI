using lesson1.models;
using lesson3.DAL;
using lesson3.Models;

namespace lesson1.DAL
{
    public class UserDal:IUserDal
    {
        private readonly TasksDBContext _context;

        public UserDal(TasksDBContext context)
        {
            _context = context;
        }

        public List<Users> GetTasks()
        {
            return _context.Users.ToList();
        }


        public void Add(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Users? user = _context.Users.Find(id);

            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public Users GetById(int id)
        {
            Users? user = _context.Users.Find(id);
            return user;
        }

        public void Update(Users user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
