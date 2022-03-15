using Backend.Domain.Entities.Movie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Repository.Mappings
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("tb_movie")/*.HasKey(x => x.Id)*/;
            //builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int");
            builder.Property(x => x.Count).HasColumnName("count").HasColumnType("smallint");
            builder.Property(x => x.Image).HasColumnName("image").HasColumnType("varchar(255)");
            builder.Property(x => x.Score).HasColumnName("score").HasColumnType("float");
            builder.Property(x => x.Title).HasColumnName("title").HasColumnType("varchar(255)");
        }
    }
}
