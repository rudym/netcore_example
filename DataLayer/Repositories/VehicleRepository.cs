using System;
using System.Collections.Generic;
using System.Linq;
using VehWebApp.Models.Vehicles;

namespace VehWebApp.DataLayer.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private VehDbContext _context;
        
        /// <summary>
        ///     the place .NET Core DI strikes helping us 
        ///     by automatically sending here VehDbContext object
        /// </summary>
        public VehicleRepository(VehDbContext VehicleContext)
        {
            
            this._context = VehicleContext;
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public Vehicle GetVehicleByID(int id)
        {
            return _context.Vehicles.FirstOrDefault(p => p.Id == id);
        }

        public Vehicle InsertVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            if (_context.SaveChanges() > 0)
            {
                return vehicle;
            }
            return null;
        }

        public void DeleteVehicle(int vehicleID)
        {
            Vehicle Vehicle = _context.Vehicles.First(p => p.Id == vehicleID);
            _context.Vehicles.Remove(Vehicle);
        }

        public void UpdateVehicle(UsedVehicle vehicle)
        {
            var result = _context.Vehicles.OfType<UsedVehicle>().FirstOrDefault(b => b.Id == vehicle.Id);
            if (result != null)
            {
                result.Description = vehicle.Description;
                result.Kilometres = vehicle.Kilometres;
                result.PurchaseDate = vehicle.PurchaseDate;
                result.BasePrice = vehicle.BasePrice;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Vehicle> GetNewVehicles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsedVehicle> GetUsedVehicles()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch
            {
                // TODO: catch errors and pobably log them
                throw;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}