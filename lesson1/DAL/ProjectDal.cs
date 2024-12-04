using lesson1.models;
using lesson3.DAL;
using lesson3.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace lesson1.DAL
{
    public class ProjectDal : IProjectDal
    {
        private readonly TasksDBContext _context;
        public IConfiguration _configuration;

        public ProjectDal(TasksDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
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

        //public bool ProcessTransaction(Task task1,Projects project)
        //{

        //    string connectionString = _configuration.GetConnectionString("DefaultConnection");

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Start a local transaction
        //        SqlTransaction transaction = connection.BeginTransaction();

        //        try
        //        {
        //            using (SqlCommand command1 = new SqlCommand("INSERT INTO Projects (ProjectId),(Title),(Gender),(DueDate)" +
        //                "VALUES (@ProjectId),(@Title),(@Gender),(@DueDate)", connection, transaction))
        //            {
        //                command1.Parameters.AddWithValue("@ProjectId", project.ProjectId);
        //                command1.Parameters.AddWithValue("@Title", project.Title);
        //                command1.Parameters.AddWithValue("@ProjectId", project.Gender);
        //                command1.Parameters.AddWithValue("@Title", project.DueDate);
        //                command1.ExecuteNonQuery();
        //            }

        //            using (SqlCommand command2 = new SqlCommand("INSERT INTO Tasks (Id),(Priority),(DueDate),(Status),(ProjectId),(UserId),(AttachId) VALUES (@Id),(@Priority),(@DueDate),(@Status),(@ProjectId),(@UserId),(@AttachId)", connection, transaction))
        //            {
        //                command2.Parameters.AddWithValue("@Id", task1.Id);
        //                command2.Parameters.AddWithValue("@Priority", task1.Priority);
        //                command2.Parameters.AddWithValue("@DueDate", task1.DueDate);
        //                command2.Parameters.AddWithValue("@Status", task1.Status);
        //                command2.Parameters.AddWithValue("@ProjectId", task1.ProjectId);
        //                command2.Parameters.AddWithValue("@UserId", project.DueDate);
        //                command2.Parameters.AddWithValue("@AttachId", project.DueDate);
        //                command2.ExecuteNonQuery();
        //            }

        //            transaction.Commit();
        //            Console.WriteLine("Transaction committed.");
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Transaction failed: " + ex.Message);
        //            try
        //            {
        //                transaction.Rollback();
        //                return false;
        //            }
        //            catch (Exception rollbackEx)
        //            {
        //                Console.WriteLine("Rollback failed: " + rollbackEx.Message);
        //                return false;
        //            }
        //        }
        //    }
        //}
    }
}
