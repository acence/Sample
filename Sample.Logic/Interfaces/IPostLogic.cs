namespace Sample.Logic.Interfaces
{
	using Base.Interfaces;
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using TransferModels;

	public interface IPostLogic : IBaseLogic<PostDto>
    {
		Task<PostDto> GetBySlug(string slug);
	}
}