﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Proyecto_Integrador_JS_DM_PZ.Migrations
{
    [DbContext(typeof(Proyecto_Integrador_JS_DM_PZContext))]
    partial class Proyecto_Integrador_JS_DM_PZContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogPostTag", b =>
                {
                    b.Property<Guid>("BlogPostsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BlogPostsID", "TagsID");

                    b.HasIndex("TagsID");

                    b.ToTable("BlogPostTag");
                });

            modelBuilder.Entity("Proyecto_Integrador_JS_DM_PZ.Models.Dominio.BlogPost", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Encabezado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManejoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TituloPagina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visibilidad")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("BlogPost");
                });

            modelBuilder.Entity("Proyecto_Integrador_JS_DM_PZ.Models.Dominio.Tag", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDisplay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("BlogPostTag", b =>
                {
                    b.HasOne("Proyecto_Integrador_JS_DM_PZ.Models.Dominio.BlogPost", null)
                        .WithMany()
                        .HasForeignKey("BlogPostsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Integrador_JS_DM_PZ.Models.Dominio.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
