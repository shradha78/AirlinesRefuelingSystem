using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Mars_Backend.Data;
using Team_Mars_Backend.Data_Admin.Entity_Admin;

namespace Team_Mars_Backend.Repository
{
    public class FuelRepository
    {
        public DatabaseContext _fuelContext;
        public FuelRepository(DatabaseContext fuelContext)
        {
            _fuelContext = fuelContext;
        }
        public IEnumerable<FuelTable> GetAllFuel()
        {
            return _fuelContext.fuelDetails;
        }

        public FuelTable GetFuelWithID(string id)
        {
            var fuelFound = _fuelContext.fuelDetails.FirstOrDefault(s => s.Fuel_Id == id);
            return fuelFound;
        }
        public FuelTable updateFuelQuantity(string fuelId, int quantity)
        {
            var fuelFound = _fuelContext.fuelDetails.First(a => a.Fuel_Id == fuelId );
            fuelFound.Fuel_quantity= fuelFound.Fuel_quantity - quantity;
            this._fuelContext.SaveChanges();
            return fuelFound;
        }
        public float GetFuelPrice(string id)
        {
            var fuelFound = _fuelContext.fuelDetails.FirstOrDefault(s => s.Fuel_Id == id);
            return fuelFound.Fuel_price;
        }

    }

}
