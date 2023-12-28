using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Core.Entities;
using Api.Core.Repositories;
using Api.Data.DataAccessLayer;

namespace Api.Data.Repositories.Implementations
{
    public class WorkerRepository : GenericRepository<Worker>, IWorkerRepository
    {
        public WorkerRepository(AppDbContext context) : base(context)
        {

        }
    }
}
