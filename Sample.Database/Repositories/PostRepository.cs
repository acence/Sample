namespace Sample.Database.Repositories
{
    using Base;
    using Infrastructure;
    using Interfaces;
    using Models;
    using System;

    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(IDatabaseContext context) : base(context)
        {
        }
    }
}
