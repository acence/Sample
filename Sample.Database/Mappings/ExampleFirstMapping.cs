namespace Sample.Database.Mappings
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public partial class ExampleFirstMap : EntityTypeConfiguration<ExampleFirst>
    {
        public ExampleFirstMap()
        {
            ToTable("ExampleFirst");
            HasKey(bp => bp.Id);
            Property(bp => bp.Name).IsRequired();
        }
    }
}

