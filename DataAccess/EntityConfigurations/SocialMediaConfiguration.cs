using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class SocialMediaConfiguration: IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.ToTable("SocialMedias").HasKey(sm => sm.Id);

        builder.Property(sm=>sm.Id).HasColumnName("Id").IsRequired();
        builder.Property(sm=>sm.Name).HasColumnName("Name").IsRequired();
        builder.Property(sm=>sm.Url).HasColumnName("Url").IsRequired();
        

        //builder.HasQueryFilter(sm => !sm.DeletedDate.HasValue);
        //builder.HasOne(sm=>);
        //builder.HasOne(sm=>sm.Url);
        
        /*
         public Guid UserId { get; set; }
           public string Name { get; set; }
           public string Url { get; set; }
           public User User { get; set; }
         */
    }
}