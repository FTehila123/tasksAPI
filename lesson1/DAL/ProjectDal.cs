using lesson1.models;
using lesson3.DAL;
using lesson3.Models;

namespace lesson1.DAL
{
    public class ProjectDal : IProjectDal
    {
        private readonly TasksDBContext _context;

        public ProjectDal(TasksDBContext context)
        {
            _context = context;
        }

        public List<Projects> GetTasks()
        {
            return _context.Projects.ToList();
        }


        public void Add(Projects project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Projects? project = _context.Projects.Find(id);

            if (project != null)
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
            }
        }

        public Projects GetById(int id)
        {
            Projects? project = _context.Projects.Find(id);
            return project;
        }

        public void Update(Projects project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }
    }
}
