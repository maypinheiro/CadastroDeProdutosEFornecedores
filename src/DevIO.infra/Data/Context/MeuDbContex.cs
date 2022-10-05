﻿using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Produtos;
using DevIO.infra.Data.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DevIO.infra.Data.Context
{
  public class MeuDbContex : DbContext
    {
        public MeuDbContex() : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet <Produto> Produtos { get; set; }
        public DbSet <Endereco> Enderecos { get; set; }
        public DbSet <Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p
                .HasColumnType("varchar")
                .HasMaxLength(100));


            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }

    }
}
