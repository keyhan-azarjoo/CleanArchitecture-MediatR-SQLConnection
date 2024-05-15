using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Entities;

public class Post : Base
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public IEnumerable<Comment> Comments { get; set; }
    public IEnumerable<PostTag> PostTags { get; set; }
}



public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Posts");
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Title).HasMaxLength(50);
        builder.Property(p => p.Content).HasMaxLength(1000);
    }
}