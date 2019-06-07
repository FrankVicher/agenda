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
    [Migration("20190606152814_AddPhoneTypes")]
    partial class AddPhoneTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}