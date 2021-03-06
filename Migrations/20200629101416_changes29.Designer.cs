﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using delishapplication.Models;

namespace delishapplication.Migrations
{
    [DbContext(typeof(delishapplicationContext))]
    [Migration("20200629101416_changes29")]
    partial class changes29
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("delishapplication.Models.Chef", b =>
                {
                    b.Property<int>("ChefID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChefUserName")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Cuisine")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Experience");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("Kosher");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("ChefID");

                    b.ToTable("Chef");
                });

            modelBuilder.Entity("delishapplication.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ClientUserName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("delishapplication.Models.Dish", b =>
                {
                    b.Property<int>("DishID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChefID");

                    b.Property<int?>("ChefID1");

                    b.Property<string>("Description");

                    b.Property<string>("DishName")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.Property<bool>("Spicy");

                    b.Property<bool>("Vegan");

                    b.HasKey("DishID");

                    b.HasIndex("ChefID1");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("delishapplication.Models.DishOrder", b =>
                {
                    b.Property<int>("DishID");

                    b.Property<int>("OrderID");

                    b.HasKey("DishID", "OrderID");

                    b.HasIndex("OrderID");

                    b.ToTable("DishOrder");
                });

            modelBuilder.Entity("delishapplication.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<int?>("ChefID");

                    b.Property<int?>("ClientID");

                    b.Property<string>("ClientUserName");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderNumber");

                    b.Property<int>("TotalPrice");

                    b.HasKey("OrderID");

                    b.HasIndex("ChefID");

                    b.HasIndex("ClientID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("delishapplication.Models.Dish", b =>
                {
                    b.HasOne("delishapplication.Models.Chef", "Chef")
                        .WithMany("MyDishes")
                        .HasForeignKey("ChefID1");
                });

            modelBuilder.Entity("delishapplication.Models.DishOrder", b =>
                {
                    b.HasOne("delishapplication.Models.Dish", "Dish")
                        .WithMany("DishOrder")
                        .HasForeignKey("DishID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("delishapplication.Models.Order", "Order")
                        .WithMany("DishOrder")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("delishapplication.Models.Order", b =>
                {
                    b.HasOne("delishapplication.Models.Chef", "Chef")
                        .WithMany()
                        .HasForeignKey("ChefID");

                    b.HasOne("delishapplication.Models.Client")
                        .WithMany("MyOrders")
                        .HasForeignKey("ClientID");
                });
#pragma warning restore 612, 618
        }
    }
}
