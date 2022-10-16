using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure._api
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// https://docs.microsoft.com/en-us/rest/api/azure/devops/?view=azure-devops-rest-7.1
	/// </remarks>
	public class Version_
	{
		public const string V2_0 = "2.0";
		/// <summary>
		/// https://docs.microsoft.com/en-us/azure/devops/integrate/how-to/call-rest-api?view=azure-devops
		/// API version must be specified with every request.
		/// Once an API is released (1.0, for example), its preview version (1.0-preview) is deprecated and can be deactivated after 12 weeks.
		/// Now, you should upgrade to the released version of the API.Once a preview API is deactivated, requests that specify -preview version gets rejected.
		/// </summary>
		public const string V2_0_preview = "2.0-preview";

		public const string V2_1 = "2.1";

		public const string V2_2 = "2.2";
		public const string V2_3 = "2.3";
		public const string V3 = "3.0";
		public const string V4 = "4.0";

		/// <summary>
		/// Where are the earlier versions of REST APIs? (Before 4.1)
		///We recently made a change to our engineering system and documentation generation process; we made this change to provide clearer, more in-depth, and more accurate documentation for everyone trying to use these REST APIs. Due to technical constraints, we are only able to document API Version 4.1 and newer using this method. We believe the documentation for API Version 4.1 and newer will be easier to use due to this change.
		///If you are working in TFS or are looking for the older versions of REST APIs, you can take a look at the Pre-Version 4.1 REST API documentation.
		/// </summary>
		public const string V4_1 = "4.1";

		public const string V6 = "6.0";
		/// <summary>
		/// vNext as of 220212
		/// </summary>
		public const string V7_1 = "7.1";

	}
}
