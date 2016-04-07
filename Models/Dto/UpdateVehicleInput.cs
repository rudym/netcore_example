using System;

namespace VehWebApp.Models.Dto
{
    /// <summary>
    ///     Class used as DTO for taking an input
    ///     on Vehicle entity update
    /// </summary>
    public class UpdateVehicleInput
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Kilometres { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}