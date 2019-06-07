﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using agenda.Data;

namespace agenda.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190607015931_AddPhones")]
    partial class AddPhones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("agenda.Data.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("agenda.Data.Entities.Mail", b =>
                {
                    b.Property<int>("MailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("MailAddress")
                        .IsRequired()
                        .HasMaxLength(254);

                    b.Property<int>("MailTypeId");

                    b.HasKey("MailId");

                    b.HasIndex("MailTypeId");

                    b.ToTable("Mail");
                });

            modelBuilder.Entity("agenda.Data.Entities.MailType", b =>
                {
                    b.Property<int>("MailTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("MailTypeId");

                    b.ToTable("MailTypes");

                    b.HasData(
                        new { MailTypeId = 1, IsActive = true, Name = "Trabajo" },
                        new { MailTypeId = 2, IsActive = true, Name = "Personal" },
                        new { MailTypeId = 3, IsActive = true, Name = "Otro" }
                    );
                });

            modelBuilder.Entity("agenda.Data.Entities.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("PhoneTypeId");

                    b.HasKey("PhoneId");

                    b.HasIndex("PhoneTypeId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("agenda.Data.Entities.PhoneType", b =>
                {
                    b.Property<int>("PhoneTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("PhoneTypeId");

                    b.ToTable("PhoneTypes");

                    b.HasData(
                        new { PhoneTypeId = 1, IsActive = true, Name = "Movil" },
                        new { PhoneTypeId = 2, IsActive = true, Name = "Trabajo" },
                        new { PhoneTypeId = 3, IsActive = true, Name = "Casa" },
                        new { PhoneTypeId = 4, IsActive = true, Name = "Fax" },
                        new { PhoneTypeId = 5, IsActive = true, Name = "Localizador" },
                        new { PhoneTypeId = 6, IsActive = true, Name = "Otro" }
                    );
                });

            modelBuilder.Entity("agenda.Data.Entities.Mail", b =>
                {
                    b.HasOne("agenda.Data.Entities.MailType", "Type")
                        .WithMany()
                        .HasForeignKey("MailTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("agenda.Data.Entities.Phone", b =>
                {
                    b.HasOne("agenda.Data.Entities.PhoneType", "PhoneType")
                        .WithMany()
                        .HasForeignKey("PhoneTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
