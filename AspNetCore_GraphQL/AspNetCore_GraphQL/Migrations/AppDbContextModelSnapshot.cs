// <auto-generated />
using System;
using Aspncore_GraphQL.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCore_GraphQL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aspncore_GraphQL.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Aspncore_GraphQL.Entities.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<float>("Estoque");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<decimal>("Preco");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Aspncore_GraphQL.Entities.Produto", b =>
                {
                    b.HasOne("Aspncore_GraphQL.Entities.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
