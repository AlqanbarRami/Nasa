using CompleteApplication.Domain.Models;
using CompleteApplication.Domain.Repositories;
using CompleteApplication.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteApplication.Persistence.Repositories
{
    public class DroneRepository : BaseRepository, IDroneRepository
    {
        public DroneRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Drone> GetDroneByIdAsync(int id)
        {
            IQueryable<Drone> query = context.Drones;

            query = query.Where(d => d.DroneId == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Drone> GetByNameAsync(string name)
        {
            IQueryable<Drone> query = context.Drones;

            query = query.Where(d => d.DroneName == name);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Drone>> ListAsync()
        {
            return await context.Drones.ToListAsync();
        }
    }
}
