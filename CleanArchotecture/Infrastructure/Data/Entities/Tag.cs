﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Entities;

public class Tag : Base
{
    public string Title { get; set; }
    public IEnumerable<PostTag> PostTags { get; set; }

}

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable("Tags");
        builder.HasKey(x => x.Id);

    }
}