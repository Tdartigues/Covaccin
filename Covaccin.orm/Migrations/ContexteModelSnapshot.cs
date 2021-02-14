﻿// <auto-generated />
using System;
using Covaccin.orm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Covaccin.orm.Migrations
{
    [DbContext(typeof(Contexte))]
    partial class ContexteModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Covaccin.orm.Injection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdLot")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPersonne")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Marque")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonneId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prenom")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeVaccinId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.HasIndex("TypeVaccinId");

                    b.ToTable("Injections");
                });

            modelBuilder.Entity("Covaccin.orm.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateNaissance")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EstResident_pasPersonnel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sexe")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("Covaccin.orm.TypeVaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vaccin")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypeVaccins");
                });

            modelBuilder.Entity("Covaccin.orm.Injection", b =>
                {
                    b.HasOne("Covaccin.orm.Personne", "Personne")
                        .WithMany("Injections")
                        .HasForeignKey("PersonneId");

                    b.HasOne("Covaccin.orm.TypeVaccin", "TypeVaccin")
                        .WithMany("Injections")
                        .HasForeignKey("TypeVaccinId");

                    b.Navigation("Personne");

                    b.Navigation("TypeVaccin");
                });

            modelBuilder.Entity("Covaccin.orm.Personne", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("Covaccin.orm.TypeVaccin", b =>
                {
                    b.Navigation("Injections");
                });
#pragma warning restore 612, 618
        }
    }
}
