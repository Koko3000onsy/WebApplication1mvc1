using ClassLibrary1.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1mvc1.Models;

namespace ClassLibrary1.DAL
{
    public class MokePlanRepository : IPlanRepository
    {
        public Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Plan plan, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Plan>> GetAllAsync(bool tracking = false, CancellationToken ct = default)
        {
            var plans = new List<Plan>()
            {
                new Plan { Id = 1, Name = "Plan A", Description = "Description for Plan A", Price = 9.99m },
              
            };
            return plans;
        }

        public Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
