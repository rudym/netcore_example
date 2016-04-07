using System;

namespace VehWebApp.Models.Dto
{
    /// <summary>
    ///     Class used as DTO for taking an input
    ///     on Vehicle entity insert
    /// </summary>
    public class VehicleDto
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime IssueDate { get; set; }

        public decimal Price { get; set; }

        public int Kilometres { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}