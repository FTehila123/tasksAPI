using lesson1.DAL;
using lesson1.models;
using System.Linq;

namespace lesson1.Services
{
    public class ProjectService: IProjectService
    {
        private readonly ITaskDal _taskDal;
        public ProjectService(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
   
    }
}
