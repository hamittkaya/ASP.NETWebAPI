using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {

            builder.HasKey(I => I.ArticleId);
            builder.Property(I => I.ArticleId).UseIdentityColumn();

            builder.Property(I => I.Title).HasMaxLength(100).IsRequired();
            builder.Property(I => I.ShortDescription).HasMaxLength(300).IsRequired();
            builder.Property(I => I.Description).HasColumnType("ntext");
            builder.Property(I => I.ImagePath).HasMaxLength(300);

            builder.HasMany(I => I.Comments).WithOne(I => I.Article).HasForeignKey(I => I.ArticleId);

            builder.HasMany(I => I.CategoryBlogs).WithOne(I => I.Article).HasForeignKey(I => I.BlogId);
        }
    }
}
