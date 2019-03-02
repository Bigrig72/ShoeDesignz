﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoeDesignz.Data;

namespace ShoeDesignz.Migrations
{
    [DbContext(typeof(ShoeDesignzDbContext))]
    partial class ShoeDesignzDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoeDesignz.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("ShoeDesignz.Models.CartItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID");

                    b.Property<int>("OrderID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShoeDesignz.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<decimal>("DiscountPrice");

                    b.Property<int>("Gender");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Sku");

                    b.HasKey("ID");

                    b.ToTable("Shoes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "These are awesome",
                            DiscountPrice = 42.00m,
                            Gender = 1,
                            Image = "https://via.placeholder.com/450",
                            Name = "Adidas",
                            Price = 234.56m,
                            Sku = 123478901
                        },
                        new
                        {
                            ID = 2,
                            Description = "These are GREAT!  I love them more than pizza!!!!",
                            DiscountPrice = 25.00m,
                            Gender = 2,
                            Image = "https://via.placeholder.com/350",
                            Name = "Nike",
                            Price = 222.22m,
                            Sku = 9876543
                        },
                        new
                        {
                            ID = 3,
                            Description = "These are ok.",
                            DiscountPrice = 5.00m,
                            Gender = 2,
                            Image = "https://via.placeholder.com/250",
                            Name = "Skech3rs",
                            Price = 33.33m,
                            Sku = 144458901
                        },
                        new
                        {
                            ID = 4,
                            Description = "Cool Coool Coool",
                            DiscountPrice = 5.00m,
                            Gender = 0,
                            Image = "https://via.placeholder.com/150",
                            Name = "Jordans",
                            Price = 44.44m,
                            Sku = 123472221
                        },
                        new
                        {
                            ID = 5,
                            Description = "Total Rip OFF!",
                            DiscountPrice = 50.00m,
                            Gender = 1,
                            Image = "https://via.placeholder.com/450",
                            Name = "Fake",
                            Price = 555.55m,
                            Sku = 123471111
                        });
                });

            modelBuilder.Entity("ShoeDesignz.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ShoeDesignz.Models.OrderItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ShoeDesignz.Models.CartItems", b =>
                {
                    b.HasOne("ShoeDesignz.Models.Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ShoeDesignz.Models.OrderItems", b =>
                {
                    b.HasOne("ShoeDesignz.Models.Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
