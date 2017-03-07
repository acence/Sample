using Sample.Web.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Configuration
{
	public static class FilterConfig
	{
		public static void RegisterFilters(GlobalFilterCollection globalFilters) {
			globalFilters.Add(new CompressResponseAttribute());
			globalFilters.Add(new MinifyHtmlAttribute());
		}
	}
}