using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Entities;

public class Comment : Base
{
    public string Content { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }

}

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comments");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Content).HasMaxLength(1000);
        builder.HasOne(e => e.Post).WithMany(c => c.Comments);
    }
}