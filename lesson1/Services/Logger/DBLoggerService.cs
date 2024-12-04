using lesson1.DAL;
using TasksApi.Services.Logger;

namespace lesson1.Services.Logger
{
    public class DBLoggerService : ILoggerService
    {
        private readonly ILoggerDal _loggerDal;
        public DBLoggerService(ILoggerDal loggerDal)
        {
            _loggerDal = loggerDal;
        }
        public void Log(string message)
        {
            _loggerDal.Add(message);
        }
    }
}
