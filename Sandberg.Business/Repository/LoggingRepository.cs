using Sandberg.Data.Contexts;
using Sandberg.Share.Models;
using System.Collections.Generic;

namespace Sandberg.Business.Repository
{
    public class LoggingRepository : ILoggingRepository
    {
        private readonly SandbergContext sandbergContext;

        public LoggingRepository()
        {
            sandbergContext = new SandbergContext();
        }

        public LoggingModel Get(int id)
        {
            return sandbergContext.LoggingModels.Find(id);
        }

        public IEnumerable<LoggingModel> Get()
        {
            return sandbergContext.LoggingModels;
        }

        public LoggingModel Add(LoggingModel loggingModel)
        {
            sandbergContext.Add(loggingModel);
            sandbergContext.SaveChanges();

            return loggingModel;
        }
    }
}