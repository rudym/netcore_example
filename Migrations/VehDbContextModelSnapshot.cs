using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using VehWebApp.DataLayer;

namespace VehWebApp.Migrations
{
    [DbContext(typeof(VehDbContext))]
    partial class VehDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("VehWebApp.Models.Vehicles.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BasePrice")
                        .HasAnnotation("Relational:ColumnName", "Price");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<DateTime>("IssueDate")
                        .HasAnnotation("Relational:ColumnName", "IssueDate");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<bool>("used_car");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "used_car");

                    b.HasAnnotation("Relational:DiscriminatorValue", false);
                });

            modelBuilder.Entity("VehWebApp.Models.Vehicles.UsedVehicle", b =>
                {
                    b.HasBaseType("VehWebApp.Models.Vehicles.Vehicle");

                    b.Property<int>("Kilometres");

                    b.Property<DateTime>("PurchaseDate")
                        .HasAnnotation("Relational:ColumnName", "PurchaseDate");

                    b.HasAnnotation("Relational:DiscriminatorValue", true);
                });
        }
    }
}
