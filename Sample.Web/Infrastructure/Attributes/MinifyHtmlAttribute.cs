using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Infrastructure.Attributes
{
	public class MinifyHtmlAttribute : ActionFilterAttribute
	{
		public override void OnResultExecuting(ResultExecutingContext filterContext)
		{
			var response = filterContext.HttpContext.Response;

			if (filterContext.Result is ViewResult)
			{
				response.Filter = new HtmlMinifierFilter(response.Filter);
			}
		}
	}

	public class HtmlMinifierFilter : MemoryStream
	{
		private readonly Stream _response;
		public HtmlMinifierFilter(Stream response)
		{
			_response = response;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			var resp = HttpContext.Current.Response;
			var charset = resp.Charset ?? "utf-8";
			var encoding = Encoding.GetEncoding(charset);
			var html = encoding.GetString(buffer, offset, count);
			html = RegexRemoveWhitespace2.Replace(RegexRemoveWhitespace.Replace(html, "><"), "> <");
			buffer = encoding.GetBytes(html);
			_response.Write(buffer, 0, buffer.Length);
		}

		private static readonly Regex RegexRemoveWhitespace = new Regex(">[\r\n][ \r\n\t]*<", RegexOptions.Multiline | RegexOptions.Compiled);
		private static readonly Regex RegexRemoveWhitespace2 = new Regex(">[ \r\n\t]+<", RegexOptions.Multiline | RegexOptions.Compiled);
	}
}