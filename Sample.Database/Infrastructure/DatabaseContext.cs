namespace Sample.Database.Infrastructure
{
    using Models.Base;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Reflection;

    public class DatabaseContext : DbContext, IDatabaseContext
    {
        #region Constructor

        public DatabaseContext() : base("DBConnectionString")
        {

        }

        #endregion
        #region Instance

        private static IDatabaseContext context = null;
        public static IDatabaseContext Current
        {
            get
            {
                if (context == null)
                {
                    context = new DatabaseContext();
                }

                return context;
            }
        }

        #endregion Instance

        #region Overrides 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(type => !String.IsNullOrEmpty(type.Namespace)).Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }

        #endregion Overrides

        #region Methods 

        public new IDbSet<T> Set<T>() where T : BaseModel
        {
            return base.Set<T>();
        }

        #endregion Methods

        #region Entity Sets


        #endregion Entity Sets
    }
}
