﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NeperiaDizionarioV2.Models.Data;

namespace NeperiaDizionarioV2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191120110418_fivethMigration")]
    partial class fivethMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NeperiaDizionarioV2.Models.Elabor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("NameFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParolaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Elabors");
                });

            modelBuilder.Entity("NeperiaDizionarioV2.Models.Parola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<string>("Termo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parola");
                });

            modelBuilder.Entity("NeperiaDizionarioV2.Models.Sinonimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParolaId")
                        .HasColumnType("int");

                    b.Property<string>("Termo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParolaId");

                    b.ToTable("Sinonimi");
                });

            modelBuilder.Entity("NeperiaDizionarioV2.Models.Sinonimo", b =>
                {
                    b.HasOne("NeperiaDizionarioV2.Models.Parola", "Parola")
                        .WithMany("Sinonimi")
                        .HasForeignKey("ParolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
