using System.IO.Compression;
using System.Web.Mvc;

namespace Sample.Web.Infrastructure.Attributes
{
	public class CompressResponseAttribute : ActionFilterAttribute
	{
		public override void OnResultExecuting(ResultExecutingContext filterContext)
		{
			var request = filterContext.HttpContext.Request;
			var acceptEncoding = request.Headers["Accept-Encoding"];

			if (string.IsNullOrEmpty(acceptEncoding))
			{
				return;
			}
			//TODO: Fix this
			return; 

			acceptEncoding = acceptEncoding.ToLowerInvariant();
			var response = filterContext.HttpContext.Response;

			if (acceptEncoding.Contains("gzip"))
			{
				response.AppendHeader("Content-encoding", "gzip");
				response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
			}
			else if (acceptEncoding.Contains("deflate"))
			{
				response.AppendHeader("Content-encoding", "deflate");
				response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
			}
		}
	}
}