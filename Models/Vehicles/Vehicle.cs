using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehWebApp.Models.Vehicles
{
    /// <summary>
    ///     Our brand entity as a Vehicle representation
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        ///     Default constructor.
        ///     Assigns some default values to properties.
        /// </summary>
        public Vehicle()
        {
            CreationTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        [Column("IssueDate")]
        [Display(Name = "Date of Issue")]
        public DateTime IssueDate { get; set; }

        [Column("Price")]
        [Display(Name = "Price")]
        public decimal BasePrice { get; set; }

        [Required]
        public DateTime CreationTime { get; set; }
    }
}