using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Sample.Web.Configuration
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/bundled/style").Include("~/Content.Style.scss"));
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						 "~/Scripts/jquery-{version}.js"));
						 
			BundleTable.EnableOptimizations = true;
		}
	}
}