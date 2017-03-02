using Sample.Logic.Interfaces;
using Sample.Logic.TransferModels;
using Sample.Web.Infrastructure.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Controllers
{
    public class PostController : BaseController
    {
        private readonly IPostLogic _postLogic;
        public PostController(IPostLogic postLogic)
        {
            _postLogic = postLogic;
        }

        // GET: Sample
        public async Task<ActionResult> Index()
        {
            var route = Request.Url.PathAndQuery;
			var post = await LookupPost(route);
            return View();
        }

        private async Task<PostDto> LookupPost(String route)
        {
			var post = await _postLogic.GetBySlug(route);

			return post;
        }
    }
}