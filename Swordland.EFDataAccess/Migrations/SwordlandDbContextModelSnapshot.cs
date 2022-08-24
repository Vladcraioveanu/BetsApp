﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Swordland.EFDataAccess;

namespace Swordland.EFDataAccess.Migrations
{
    [DbContext(typeof(SwordlandDbContext))]
    partial class SwordlandDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Swordland.ApplicationLogic.Data.Bet", b =>
                {
                    b.Property<int>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber");

                    b.Property<int>("ChallengerId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Sum");

                    b.HasKey("BetId");

                    b.HasIndex("ChallengerId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("Swordland.ApplicationLogic.Data.Challengers", b =>
                {
                    b.Property<int>("ChallengeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("StageName");

                    b.HasKey("ChallengeId");

                    b.ToTable("Challengers");
                });

            modelBuilder.Entity("Swordland.ApplicationLogic.Data.Enroll", b =>
                {
                    b.Property<int>("EnrollId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("StageName");

                    b.Property<string>("Sword");

                    b.HasKey("EnrollId");

                    b.ToTable("Enrolls");
                });

            modelBuilder.Entity("Swordland.ApplicationLogic.Data.Tickets", b =>
                {
                    b.Property<int>("TicketsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardNumber");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("MatchNumber");

                    b.Property<string>("UserId");

                    b.HasKey("TicketsId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Swordland.ApplicationLogic.Data.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Swordland.ApplicationLogic.Data.Bet", b =>
                {
                    b.HasOne("Swordland.ApplicationLogic.Data.Challengers", "Challenger")
                        .WithMany("Bets")
                        .HasForeignKey("ChallengerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Swordland.ApplicationLogic.Data.Tickets", b =>
                {
                    b.HasOne("Swordland.ApplicationLogic.Data.User", "Users")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
