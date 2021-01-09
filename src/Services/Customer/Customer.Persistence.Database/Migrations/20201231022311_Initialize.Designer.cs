﻿// <auto-generated />
using Customer.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Customer.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201231022311_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Customer")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Customer.Domain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Name = "Client 1"
                        },
                        new
                        {
                            ClientId = 2,
                            Name = "Client 2"
                        },
                        new
                        {
                            ClientId = 3,
                            Name = "Client 3"
                        },
                        new
                        {
                            ClientId = 4,
                            Name = "Client 4"
                        },
                        new
                        {
                            ClientId = 5,
                            Name = "Client 5"
                        },
                        new
                        {
                            ClientId = 6,
                            Name = "Client 6"
                        },
                        new
                        {
                            ClientId = 7,
                            Name = "Client 7"
                        },
                        new
                        {
                            ClientId = 8,
                            Name = "Client 8"
                        },
                        new
                        {
                            ClientId = 9,
                            Name = "Client 9"
                        },
                        new
                        {
                            ClientId = 10,
                            Name = "Client 10"
                        },
                        new
                        {
                            ClientId = 11,
                            Name = "Client 11"
                        },
                        new
                        {
                            ClientId = 12,
                            Name = "Client 12"
                        },
                        new
                        {
                            ClientId = 13,
                            Name = "Client 13"
                        },
                        new
                        {
                            ClientId = 14,
                            Name = "Client 14"
                        },
                        new
                        {
                            ClientId = 15,
                            Name = "Client 15"
                        },
                        new
                        {
                            ClientId = 16,
                            Name = "Client 16"
                        },
                        new
                        {
                            ClientId = 17,
                            Name = "Client 17"
                        },
                        new
                        {
                            ClientId = 18,
                            Name = "Client 18"
                        },
                        new
                        {
                            ClientId = 19,
                            Name = "Client 19"
                        },
                        new
                        {
                            ClientId = 20,
                            Name = "Client 20"
                        },
                        new
                        {
                            ClientId = 21,
                            Name = "Client 21"
                        },
                        new
                        {
                            ClientId = 22,
                            Name = "Client 22"
                        },
                        new
                        {
                            ClientId = 23,
                            Name = "Client 23"
                        },
                        new
                        {
                            ClientId = 24,
                            Name = "Client 24"
                        },
                        new
                        {
                            ClientId = 25,
                            Name = "Client 25"
                        },
                        new
                        {
                            ClientId = 26,
                            Name = "Client 26"
                        },
                        new
                        {
                            ClientId = 27,
                            Name = "Client 27"
                        },
                        new
                        {
                            ClientId = 28,
                            Name = "Client 28"
                        },
                        new
                        {
                            ClientId = 29,
                            Name = "Client 29"
                        },
                        new
                        {
                            ClientId = 30,
                            Name = "Client 30"
                        },
                        new
                        {
                            ClientId = 31,
                            Name = "Client 31"
                        },
                        new
                        {
                            ClientId = 32,
                            Name = "Client 32"
                        },
                        new
                        {
                            ClientId = 33,
                            Name = "Client 33"
                        },
                        new
                        {
                            ClientId = 34,
                            Name = "Client 34"
                        },
                        new
                        {
                            ClientId = 35,
                            Name = "Client 35"
                        },
                        new
                        {
                            ClientId = 36,
                            Name = "Client 36"
                        },
                        new
                        {
                            ClientId = 37,
                            Name = "Client 37"
                        },
                        new
                        {
                            ClientId = 38,
                            Name = "Client 38"
                        },
                        new
                        {
                            ClientId = 39,
                            Name = "Client 39"
                        },
                        new
                        {
                            ClientId = 40,
                            Name = "Client 40"
                        },
                        new
                        {
                            ClientId = 41,
                            Name = "Client 41"
                        },
                        new
                        {
                            ClientId = 42,
                            Name = "Client 42"
                        },
                        new
                        {
                            ClientId = 43,
                            Name = "Client 43"
                        },
                        new
                        {
                            ClientId = 44,
                            Name = "Client 44"
                        },
                        new
                        {
                            ClientId = 45,
                            Name = "Client 45"
                        },
                        new
                        {
                            ClientId = 46,
                            Name = "Client 46"
                        },
                        new
                        {
                            ClientId = 47,
                            Name = "Client 47"
                        },
                        new
                        {
                            ClientId = 48,
                            Name = "Client 48"
                        },
                        new
                        {
                            ClientId = 49,
                            Name = "Client 49"
                        },
                        new
                        {
                            ClientId = 50,
                            Name = "Client 50"
                        },
                        new
                        {
                            ClientId = 51,
                            Name = "Client 51"
                        },
                        new
                        {
                            ClientId = 52,
                            Name = "Client 52"
                        },
                        new
                        {
                            ClientId = 53,
                            Name = "Client 53"
                        },
                        new
                        {
                            ClientId = 54,
                            Name = "Client 54"
                        },
                        new
                        {
                            ClientId = 55,
                            Name = "Client 55"
                        },
                        new
                        {
                            ClientId = 56,
                            Name = "Client 56"
                        },
                        new
                        {
                            ClientId = 57,
                            Name = "Client 57"
                        },
                        new
                        {
                            ClientId = 58,
                            Name = "Client 58"
                        },
                        new
                        {
                            ClientId = 59,
                            Name = "Client 59"
                        },
                        new
                        {
                            ClientId = 60,
                            Name = "Client 60"
                        },
                        new
                        {
                            ClientId = 61,
                            Name = "Client 61"
                        },
                        new
                        {
                            ClientId = 62,
                            Name = "Client 62"
                        },
                        new
                        {
                            ClientId = 63,
                            Name = "Client 63"
                        },
                        new
                        {
                            ClientId = 64,
                            Name = "Client 64"
                        },
                        new
                        {
                            ClientId = 65,
                            Name = "Client 65"
                        },
                        new
                        {
                            ClientId = 66,
                            Name = "Client 66"
                        },
                        new
                        {
                            ClientId = 67,
                            Name = "Client 67"
                        },
                        new
                        {
                            ClientId = 68,
                            Name = "Client 68"
                        },
                        new
                        {
                            ClientId = 69,
                            Name = "Client 69"
                        },
                        new
                        {
                            ClientId = 70,
                            Name = "Client 70"
                        },
                        new
                        {
                            ClientId = 71,
                            Name = "Client 71"
                        },
                        new
                        {
                            ClientId = 72,
                            Name = "Client 72"
                        },
                        new
                        {
                            ClientId = 73,
                            Name = "Client 73"
                        },
                        new
                        {
                            ClientId = 74,
                            Name = "Client 74"
                        },
                        new
                        {
                            ClientId = 75,
                            Name = "Client 75"
                        },
                        new
                        {
                            ClientId = 76,
                            Name = "Client 76"
                        },
                        new
                        {
                            ClientId = 77,
                            Name = "Client 77"
                        },
                        new
                        {
                            ClientId = 78,
                            Name = "Client 78"
                        },
                        new
                        {
                            ClientId = 79,
                            Name = "Client 79"
                        },
                        new
                        {
                            ClientId = 80,
                            Name = "Client 80"
                        },
                        new
                        {
                            ClientId = 81,
                            Name = "Client 81"
                        },
                        new
                        {
                            ClientId = 82,
                            Name = "Client 82"
                        },
                        new
                        {
                            ClientId = 83,
                            Name = "Client 83"
                        },
                        new
                        {
                            ClientId = 84,
                            Name = "Client 84"
                        },
                        new
                        {
                            ClientId = 85,
                            Name = "Client 85"
                        },
                        new
                        {
                            ClientId = 86,
                            Name = "Client 86"
                        },
                        new
                        {
                            ClientId = 87,
                            Name = "Client 87"
                        },
                        new
                        {
                            ClientId = 88,
                            Name = "Client 88"
                        },
                        new
                        {
                            ClientId = 89,
                            Name = "Client 89"
                        },
                        new
                        {
                            ClientId = 90,
                            Name = "Client 90"
                        },
                        new
                        {
                            ClientId = 91,
                            Name = "Client 91"
                        },
                        new
                        {
                            ClientId = 92,
                            Name = "Client 92"
                        },
                        new
                        {
                            ClientId = 93,
                            Name = "Client 93"
                        },
                        new
                        {
                            ClientId = 94,
                            Name = "Client 94"
                        },
                        new
                        {
                            ClientId = 95,
                            Name = "Client 95"
                        },
                        new
                        {
                            ClientId = 96,
                            Name = "Client 96"
                        },
                        new
                        {
                            ClientId = 97,
                            Name = "Client 97"
                        },
                        new
                        {
                            ClientId = 98,
                            Name = "Client 98"
                        },
                        new
                        {
                            ClientId = 99,
                            Name = "Client 99"
                        },
                        new
                        {
                            ClientId = 100,
                            Name = "Client 100"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
