﻿// <auto-generated />
using LandmarkRemark.API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LandmarkRemark.API.Migrations
{
    [DbContext(typeof(LandmarkRemarkDataContext))]
    partial class LandmarkRemarkDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LandmarkRemark.API.Repository.UserLocationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("Notes")
                        .HasMaxLength(255);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLocation");
                });

            modelBuilder.Entity("LandmarkRemark.API.Repository.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LandmarkRemark.API.Repository.UserLocationModel", b =>
                {
                    b.HasOne("LandmarkRemark.API.Repository.UserModel", "User")
                        .WithMany("UserLocation")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Users_UsersLocation");
                });
#pragma warning restore 612, 618
        }
    }
}
