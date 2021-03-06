// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProfileService.DbContexts;

namespace ProfileService.Migrations
{
    [DbContext(typeof(ProfileDbContext))]
    [Migration("20210720042036_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProfileService.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhonrNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Turki",
                            LastName = "Alqurashi",
                            PhonrNumber = "05050505050",
                            ScoreId = 0
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Ahmed",
                            LastName = "Alzubaidi",
                            PhonrNumber = "05858585858",
                            ScoreId = 0
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Abdulrahman",
                            LastName = "Sarawiq",
                            PhonrNumber = "05858585858",
                            ScoreId = 0
                        });
                });

            modelBuilder.Entity("ProfileService.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
