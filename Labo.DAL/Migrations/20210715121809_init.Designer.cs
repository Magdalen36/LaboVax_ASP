﻿// <auto-generated />
using System;
using Labo.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labo.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210715121809_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labo.DAL.Entities.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodePostal")
                        .HasColumnType("int");

                    b.Property<string>("NomRue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumRue")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Adress");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodePostal = 5000,
                            NomRue = "rue de l'expo",
                            NumRue = "17A",
                            Pays = "Belgique",
                            Ville = "Namur"
                        },
                        new
                        {
                            Id = 2,
                            CodePostal = 5000,
                            NomRue = "rue du Centre",
                            NumRue = "17",
                            Pays = "Belgique",
                            Ville = "Namur"
                        },
                        new
                        {
                            Id = 3,
                            CodePostal = 5002,
                            NomRue = "rue à l'ouest",
                            NumRue = "35",
                            Pays = "Belgique",
                            Ville = "Saint-Servais"
                        },
                        new
                        {
                            Id = 4,
                            CodePostal = 5190,
                            NomRue = "rue à l'est",
                            NumRue = "17A",
                            Pays = "Belgique",
                            Ville = "Ham-sur-Sambre"
                        },
                        new
                        {
                            Id = 5,
                            CodePostal = 6000,
                            NomRue = "rue du pont",
                            NumRue = "19",
                            Pays = "Belgique",
                            Ville = "Charleroi"
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierHeure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalendrierJourId")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendrierJourId");

                    b.ToTable("CalendrierHeure");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierJour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.ToTable("CalendrierJour");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Centre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ResponsableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.ToTable("Centre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdressId = 1,
                            Name = "Namur Expo",
                            ResponsableId = 1
                        },
                        new
                        {
                            Id = 2,
                            AdressId = 2,
                            Name = "Centre Central",
                            ResponsableId = 5
                        },
                        new
                        {
                            Id = 3,
                            AdressId = 3,
                            Name = "Hall Saint-Servais",
                            ResponsableId = 9
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.Fournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.ToTable("Fournisseur");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdressId = 4,
                            FirstName = "Julie",
                            LastName = "Edouard"
                        },
                        new
                        {
                            Id = 2,
                            AdressId = 5,
                            FirstName = "Sophie",
                            LastName = "Dufranne"
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Médecin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Infirmier"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sécurité"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bénévole"
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.HeureOuverture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<int>("HeureDebut")
                        .HasColumnType("int");

                    b.Property<int>("HeureFin")
                        .HasColumnType("int");

                    b.Property<int>("Jour")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.ToTable("HeureOuverture");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CentreId = 1,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 1
                        },
                        new
                        {
                            Id = 2,
                            CentreId = 1,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 2
                        },
                        new
                        {
                            Id = 3,
                            CentreId = 1,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 3
                        },
                        new
                        {
                            Id = 4,
                            CentreId = 1,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 4
                        },
                        new
                        {
                            Id = 5,
                            CentreId = 1,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 5
                        },
                        new
                        {
                            Id = 6,
                            CentreId = 1,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 6
                        },
                        new
                        {
                            Id = 7,
                            CentreId = 1,
                            HeureDebut = 8,
                            HeureFin = 22,
                            Jour = 7
                        },
                        new
                        {
                            Id = 8,
                            CentreId = 2,
                            HeureDebut = 7,
                            HeureFin = 18,
                            Jour = 1
                        },
                        new
                        {
                            Id = 9,
                            CentreId = 2,
                            HeureDebut = 7,
                            HeureFin = 18,
                            Jour = 2
                        },
                        new
                        {
                            Id = 10,
                            CentreId = 2,
                            HeureDebut = 7,
                            HeureFin = 18,
                            Jour = 4
                        },
                        new
                        {
                            Id = 11,
                            CentreId = 2,
                            HeureDebut = 7,
                            HeureFin = 18,
                            Jour = 5
                        },
                        new
                        {
                            Id = 12,
                            CentreId = 2,
                            HeureDebut = 7,
                            HeureFin = 18,
                            Jour = 6
                        },
                        new
                        {
                            Id = 13,
                            CentreId = 2,
                            HeureDebut = 7,
                            HeureFin = 18,
                            Jour = 7
                        },
                        new
                        {
                            Id = 14,
                            CentreId = 3,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 1
                        },
                        new
                        {
                            Id = 15,
                            CentreId = 3,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 2
                        },
                        new
                        {
                            Id = 16,
                            CentreId = 3,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 3
                        },
                        new
                        {
                            Id = 17,
                            CentreId = 3,
                            HeureDebut = 8,
                            HeureFin = 20,
                            Jour = 4
                        },
                        new
                        {
                            Id = 18,
                            CentreId = 3,
                            HeureDebut = 8,
                            HeureFin = 22,
                            Jour = 5
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.Injection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalendrierHeureId")
                        .HasColumnType("int");

                    b.Property<int>("LotVaccinId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendrierHeureId");

                    b.HasIndex("LotVaccinId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PersonnelId");

                    b.ToTable("Injection");
                });

            modelBuilder.Entity("Labo.DAL.Entities.LotVaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEntree")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSortie")
                        .HasColumnType("datetime2");

                    b.Property<int>("FournisseurId")
                        .HasColumnType("int");

                    b.Property<int>("QuantiteEntree")
                        .HasColumnType("int");

                    b.Property<int>("QuantiteRestante")
                        .HasColumnType("int");

                    b.Property<int>("TypeVaccinId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.HasIndex("FournisseurId");

                    b.HasIndex("TypeVaccinId");

                    b.ToTable("LotVaccin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CentreId = 1,
                            DateEntree = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateSortie = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FournisseurId = 1,
                            QuantiteEntree = 200,
                            QuantiteRestante = 0,
                            TypeVaccinId = 1
                        },
                        new
                        {
                            Id = 2,
                            CentreId = 1,
                            DateEntree = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateSortie = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FournisseurId = 2,
                            QuantiteEntree = 400,
                            QuantiteRestante = 0,
                            TypeVaccinId = 2
                        },
                        new
                        {
                            Id = 3,
                            CentreId = 2,
                            DateEntree = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateSortie = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FournisseurId = 1,
                            QuantiteEntree = 600,
                            QuantiteRestante = 0,
                            TypeVaccinId = 3
                        },
                        new
                        {
                            Id = 4,
                            CentreId = 2,
                            DateEntree = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateSortie = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FournisseurId = 2,
                            QuantiteEntree = 100,
                            QuantiteRestante = 0,
                            TypeVaccinId = 4
                        },
                        new
                        {
                            Id = 5,
                            CentreId = 3,
                            DateEntree = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateSortie = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FournisseurId = 1,
                            QuantiteEntree = 300,
                            QuantiteRestante = 0,
                            TypeVaccinId = 1
                        },
                        new
                        {
                            Id = 6,
                            CentreId = 3,
                            DateEntree = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateSortie = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FournisseurId = 2,
                            QuantiteEntree = 500,
                            QuantiteRestante = 0,
                            TypeVaccinId = 2
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IndicMed")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("RegistreNat")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength(true);

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.ToTable("Patient");

                    b.HasCheckConstraint("CK_Mail", "Mail LIKE '_%@_%'");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Personnel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<long>("Inami")
                        .HasMaxLength(11)
                        .HasColumnType("bigint")
                        .IsFixedLength(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.HasIndex("GradeId");

                    b.ToTable("Personnel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CentreId = 1,
                            FirstName = "Pierre",
                            GradeId = 1,
                            Inami = 12312312312L,
                            LastName = "Wasnaire"
                        },
                        new
                        {
                            Id = 2,
                            CentreId = 1,
                            FirstName = "Jean",
                            GradeId = 2,
                            Inami = 12312312312L,
                            LastName = "Jacques"
                        },
                        new
                        {
                            Id = 3,
                            CentreId = 1,
                            FirstName = "Marie",
                            GradeId = 3,
                            Inami = 0L,
                            LastName = "Dupont"
                        },
                        new
                        {
                            Id = 4,
                            CentreId = 1,
                            FirstName = "Edouard",
                            GradeId = 4,
                            Inami = 0L,
                            LastName = "Perot"
                        },
                        new
                        {
                            Id = 5,
                            CentreId = 2,
                            FirstName = "Pol",
                            GradeId = 1,
                            Inami = 12312312317L,
                            LastName = "Wasnaire"
                        },
                        new
                        {
                            Id = 6,
                            CentreId = 2,
                            FirstName = "Jean",
                            GradeId = 2,
                            Inami = 12312312319L,
                            LastName = "Poarr"
                        },
                        new
                        {
                            Id = 7,
                            CentreId = 2,
                            FirstName = "Marie",
                            GradeId = 3,
                            Inami = 0L,
                            LastName = "Durand"
                        },
                        new
                        {
                            Id = 8,
                            CentreId = 2,
                            FirstName = "Josef",
                            GradeId = 4,
                            Inami = 0L,
                            LastName = "quier"
                        },
                        new
                        {
                            Id = 9,
                            CentreId = 3,
                            FirstName = "Pierre",
                            GradeId = 1,
                            Inami = 12312312311L,
                            LastName = "moraud"
                        },
                        new
                        {
                            Id = 10,
                            CentreId = 3,
                            FirstName = "Maud",
                            GradeId = 2,
                            Inami = 12312312318L,
                            LastName = "Perot"
                        },
                        new
                        {
                            Id = 11,
                            CentreId = 3,
                            FirstName = "Justine",
                            GradeId = 3,
                            Inami = 0L,
                            LastName = "Renson"
                        },
                        new
                        {
                            Id = 12,
                            CentreId = 3,
                            FirstName = "Patricia",
                            GradeId = 4,
                            Inami = 0L,
                            LastName = "Delrio"
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.TypeVaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeVaccin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Moderna"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pfizer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Johnson & Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Name = "AstraZeneca"
                        });
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierHeure", b =>
                {
                    b.HasOne("Labo.DAL.Entities.CalendrierJour", "CalendrierJour")
                        .WithMany("CalendrierHeures")
                        .HasForeignKey("CalendrierJourId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CalendrierJour");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierJour", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("CalendrierJours")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Centre", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Adress", "Adress")
                        .WithOne("Centre")
                        .HasForeignKey("Labo.DAL.Entities.Centre", "AdressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Fournisseur", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Adress", "Adress")
                        .WithOne("Fournisseur")
                        .HasForeignKey("Labo.DAL.Entities.Fournisseur", "AdressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Labo.DAL.Entities.HeureOuverture", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("HeureOuvertures")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Injection", b =>
                {
                    b.HasOne("Labo.DAL.Entities.CalendrierHeure", "CalendrierHeure")
                        .WithMany("Injections")
                        .HasForeignKey("CalendrierHeureId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.LotVaccin", "LotVaccin")
                        .WithMany()
                        .HasForeignKey("LotVaccinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Patient", "Patient")
                        .WithMany("Injections")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalendrierHeure");

                    b.Navigation("LotVaccin");

                    b.Navigation("Patient");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("Labo.DAL.Entities.LotVaccin", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("LotVaccins")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Fournisseur", "Fournisseur")
                        .WithMany("LotVaccins")
                        .HasForeignKey("FournisseurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.TypeVaccin", "TypeVaccin")
                        .WithMany("LotVaccins")
                        .HasForeignKey("TypeVaccinId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");

                    b.Navigation("Fournisseur");

                    b.Navigation("TypeVaccin");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Patient", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Adress", "Adress")
                        .WithOne("Patient")
                        .HasForeignKey("Labo.DAL.Entities.Patient", "AdressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Personnel", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("Personnels")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Grade", "Grade")
                        .WithMany("Personnels")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Adress", b =>
                {
                    b.Navigation("Centre");

                    b.Navigation("Fournisseur");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierHeure", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierJour", b =>
                {
                    b.Navigation("CalendrierHeures");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Centre", b =>
                {
                    b.Navigation("CalendrierJours");

                    b.Navigation("HeureOuvertures");

                    b.Navigation("LotVaccins");

                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Fournisseur", b =>
                {
                    b.Navigation("LotVaccins");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Grade", b =>
                {
                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Patient", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("Labo.DAL.Entities.TypeVaccin", b =>
                {
                    b.Navigation("LotVaccins");
                });
#pragma warning restore 612, 618
        }
    }
}