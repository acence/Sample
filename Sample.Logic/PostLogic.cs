namespace Sample.Logic
{
	using AutoMapper;
	using Base;
	using Database.Models;
	using Database.Repositories.Interfaces;
	using Interfaces;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Threading.Tasks;
	using TransferModels;

	public class PostLogic : BaseLogic<IPostRepository, Post, PostDto>, IPostLogic
    {
        public PostLogic(IPostRepository db, IMapper mapper)
            : base(db, mapper)
        {
		}
		public async Task<PostDto> GetBySlug(string slug)
		{
			return _mapper.Map<PostDto>(await _db.Select().FirstOrDefaultAsync(x => x.Slug.Equals(slug, StringComparison.InvariantCultureIgnoreCase)));
		}
	}
}
