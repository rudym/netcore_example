using System;
using System.Collections.Generic;

namespace VehWebApp.Models.Vehicles
{
    /// <summary>
    ///     interface to implement for working with Vehicles entities
    /// </summary>
    public interface IVehicleRepository : IDisposable
    {
        IEnumerable<Vehicle> GetVehicles();
        IEnumerable<Vehicle> GetNewVehicles();
        IEnumerable<UsedVehicle> GetUsedVehicles();
        Vehicle GetVehicleByID(int vehicleId);
        Vehicle InsertVehicle(Vehicle vehicle);
        void DeleteVehicle(int vehicleId);
        void UpdateVehicle(UsedVehicle vehicle);
        void Save();
    }
}