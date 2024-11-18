using lesson3.Models;

namespace lesson1.DAL
{
    public interface IProjectDal
    {
        public List<Projects> GetTasks();
        public void Add(Projects project);
        public void Delete(int id);
        public Projects GetById(int id);
        public void Update(Projects project);

    }
}
