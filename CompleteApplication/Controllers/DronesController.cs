using CompleteApplication.Domain.Models;
using CompleteApplication.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CompleteApplication.Resources;

namespace CompleteApplication.Controllers
{

    [Route("/api/[controller]")]
    public class DronesController
    {
        private readonly IDroneService droneService;
        private readonly IMapper mapper;

        public DronesController(IDroneService droneService, IMapper mapper)
        {
            this.droneService = droneService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<DroneResource>> GetAllAsync()
        {
            var drones = await droneService.ListAsync();
            var resources = mapper.Map<IEnumerable<Drone>, IEnumerable<DroneResource>>(drones);
            return resources;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DroneResource>> GetDrone(int id)
        {
            var drone = await droneService.GetDroneByIdAsync(id);
            var resource1 = mapper.Map<Drone, DroneResource>(drone);


            return resource1;
        }

       
        [HttpGet("rovers/{name}")]
        public async Task<ActionResult<DroneResource>> GetByName(string name)
        {
            var drone = await droneService.GetByNameAsync(name);
            var resource2 = mapper.Map<Drone, DroneResource>(drone);

            return resource2;
        }


    }
}
