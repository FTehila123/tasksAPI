using lesson3.Models;

namespace lesson1.DAL
{
    public interface IUserDal
    {
        public List<Users> GetTasks();
        public void Add(Users user);
        public void Delete(int id);
        public Users GetById(int id);
        public void Update(Users user);
    }
}
