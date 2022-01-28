using CompleteApplication.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompleteApplication.Domain.Services
{
    public interface IDroneService
    {

        Task<IEnumerable<Drone>> ListAsync();
        Task<Drone> GetDroneByIdAsync(int id);

        Task<Drone> GetByNameAsync(string name);
    }
}
