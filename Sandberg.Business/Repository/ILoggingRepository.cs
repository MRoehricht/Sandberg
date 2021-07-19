using Sandberg.Share.Models;
using System.Collections.Generic;

namespace Sandberg.Business.Repository
{
    public interface ILoggingRepository
    {
        LoggingModel Add(LoggingModel loggingModel);
        IEnumerable<LoggingModel> Get();
        LoggingModel Get(int id);
    }
}