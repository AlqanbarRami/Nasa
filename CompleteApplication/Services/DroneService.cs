using CompleteApplication.Domain.Models;
using CompleteApplication.Domain.Repositories;
using CompleteApplication.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompleteApplication.Services
{
    public class DroneService : IDroneService
    {
        private readonly IDroneRepository droneRespository;

        public DroneService(IDroneRepository droneRespository)
        {
            this.droneRespository = droneRespository;
        }

        public async Task<Drone> GetDroneByIdAsync(int id)
        {
            return await droneRespository.GetDroneByIdAsync(id);
        }

        public async Task<Drone> GetByNameAsync(string name)
        {
            return await droneRespository.GetByNameAsync(name);
        }

        public async Task<IEnumerable<Drone>> ListAsync()
        {
            return await droneRespository.ListAsync();
        }
    }
}
