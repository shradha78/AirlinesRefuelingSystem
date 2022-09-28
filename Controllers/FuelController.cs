using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team_Mars_Backend.Data_Admin.Entity_Admin;
using Team_Mars_Backend.Repository;

namespace Team_Mars_Backend.Controllers
{
    [Route("fuel/[controller]")]
    [ApiController]

    public class FuelController : ControllerBase
    {
        public FuelRepository _repo;

        public FuelController(FuelRepository _repo)
        {
            this._repo = _repo;
        }

        [HttpGet]
        public IEnumerable<FuelTable> Get()
        {
            return _repo.GetAllFuel();
        }

        [HttpGet("{Fuel_Id}")]
        public FuelTable GetWithId(string id)
        {
            return _repo.GetFuelWithID(id);
        }
        [HttpGet("{Fuel_Id}")]
        public float GetFuelPrice(string id)
        {
            return _repo.GetFuelPrice(id);
        }
    }
}