using DevIO.Business.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;



namespace DevIO.infra.Data.Mappings
{
    class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(p => p.Id);

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(c =>c.Numero)
                .IsRequired()
                .HasMaxLength(10);

            Property(c => c.Cep)
                 .IsRequired()
                 .HasMaxLength(8)
                 .IsFixedLength();

            Property(c => c.Complemento)
                .HasMaxLength(250);

            Property(c => c.Bairro)
              .IsRequired()
              .HasMaxLength(100);

            Property(c => c.Cidade)
              .IsRequired()
              .HasMaxLength(100);

            Property(c => c.Estado)
               .IsRequired()
               .HasMaxLength(100);

            ToTable("Enderecos");

        }
    }
}
