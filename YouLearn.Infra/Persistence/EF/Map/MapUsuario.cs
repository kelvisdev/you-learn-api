using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouLearn.Domain.Entities;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Infra.Persistence.EF.Map
{
    public class MapUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Nome Tabela
            builder.ToTable("Usuario");

            // Chave Primaria
            builder.HasKey(x => x.Id);

            builder.Property(X => X.Senha).HasMaxLength(36).IsRequired();

            // Mapeando Objetos de valor

            builder.OwnsOne<Nome>(x => x.Nome, callback => {
                callback.Property(x => x.PrimeiroNome).HasMaxLength(50).HasColumnName("PrimeiroNome").IsRequired();
                callback.Property(x => x.UltimoNome).HasMaxLength(50).HasColumnName("UltimoNome").IsRequired();
            });


            builder.OwnsOne<Email>(x => x.Email, callback => {
                callback.Property(x => x.Endereco).HasMaxLength(50).HasColumnName("Email").IsRequired();
            });
        }
    }
}
