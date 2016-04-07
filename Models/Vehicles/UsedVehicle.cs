using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehWebApp.Models.Vehicles
{
    /// <summary>
    ///     Entity that inherits from Vehicle entity
    ///     for demonstration purposes
    /// </summary>
    public class UsedVehicle : Vehicle
    {
        [MinLength(0)]
        public int Kilometres { get; set; }

        [Column("PurchaseDate")]
        [Display(Name = "Date of Purchase")]
        public DateTime PurchaseDate { get; set; }

    }
}