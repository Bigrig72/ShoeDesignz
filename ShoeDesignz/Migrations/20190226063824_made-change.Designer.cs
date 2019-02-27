﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoeDesignz.Data;

namespace ShoeDesignz.Migrations
{
    [DbContext(typeof(ShoeDesignzDbContext))]
    [Migration("20190226063824_made-change")]
    partial class madechange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoeDesignz.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

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
                            Gender = 1,
                            Image = "https://via.placeholder.com/450",
                            Name = "Fake",
                            Price = 555.55m,
                            Sku = 123471111
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
