namespace Sample.Database.Mappings
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public partial class ExampleFirstMap : EntityTypeConfiguration<Post>
    {
        public ExampleFirstMap()
        {
            ToTable("Posts");
            HasKey(bp => bp.Id);
            Property(bp => bp.Name).IsRequired();
			Property(x => x.Slug).HasMaxLength(256).IsRequired();
        }
    }
}

