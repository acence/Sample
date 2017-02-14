namespace Sample.Database.Repositories
{
    using Base;
    using Infrastructure;
    using Interfaces;
    using Models;
    using System;

    public class ExampleFirstRepository : BaseRepository<ExampleFirst>, IExampleFirstRepository
    {
        public ExampleFirstRepository(IDatabaseContext context) : base(context)
        {
        }
    }
}
