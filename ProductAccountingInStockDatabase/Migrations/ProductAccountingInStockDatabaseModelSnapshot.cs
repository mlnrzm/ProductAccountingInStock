﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAccountingInStockDatabase;

namespace ProductAccountingInStockDatabase.Migrations
{
    [DbContext(typeof(ProductAccountingInStockDatabase))]
    partial class ProductAccountingInStockDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.DirectionShipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DirectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DirectionShipments");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeFIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("SupervisorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProviderAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Shipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateImplement")
                        .HasColumnType("datetime2");

                    b.Property<int>("DirectionShipmentId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("ShipmentStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DirectionShipmentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.ShipmentProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShipmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShipmentId");

                    b.ToTable("ShipmentProducts");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Employee", b =>
                {
                    b.HasOne("ProductAccountingInStockDatabase.DatabaseModels.Post", "EmployeePost")
                        .WithMany("Employees")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeePost");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Product", b =>
                {
                    b.HasOne("ProductAccountingInStockDatabase.DatabaseModels.Provider", "Provider")
                        .WithMany("Products")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Shipment", b =>
                {
                    b.HasOne("ProductAccountingInStockDatabase.DatabaseModels.DirectionShipment", "DirectionShipment")
                        .WithMany("Shipments")
                        .HasForeignKey("DirectionShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductAccountingInStockDatabase.DatabaseModels.Employee", "Employee")
                        .WithMany("Shipments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirectionShipment");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.ShipmentProduct", b =>
                {
                    b.HasOne("ProductAccountingInStockDatabase.DatabaseModels.Product", "Product")
                        .WithMany("ShipmentProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductAccountingInStockDatabase.DatabaseModels.Shipment", "Shipment")
                        .WithMany("ShipmentProducts")
                        .HasForeignKey("ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.DirectionShipment", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Employee", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Post", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Product", b =>
                {
                    b.Navigation("ShipmentProducts");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Provider", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ProductAccountingInStockDatabase.DatabaseModels.Shipment", b =>
                {
                    b.Navigation("ShipmentProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
