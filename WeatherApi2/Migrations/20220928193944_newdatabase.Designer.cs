// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherApi2.Data;

#nullable disable

namespace WeatherApi2.Migrations
{
    [DbContext(typeof(ForecastDBContext))]
    [Migration("20220928193944_newdatabase")]
    partial class newdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WeatherApi2.Models.Main", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<double>("feels_like")
                        .HasColumnType("float");

                    b.Property<int>("grnd_level")
                        .HasColumnType("int");

                    b.Property<int>("humidity")
                        .HasColumnType("int");

                    b.Property<int>("pressure")
                        .HasColumnType("int");

                    b.Property<int>("sea_level")
                        .HasColumnType("int");

                    b.Property<double>("temp")
                        .HasColumnType("float");

                    b.Property<double>("temp_kf")
                        .HasColumnType("float");

                    b.Property<double>("temp_max")
                        .HasColumnType("float");

                    b.Property<double>("temp_min")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Mains");
                });
#pragma warning restore 612, 618
        }
    }
}
