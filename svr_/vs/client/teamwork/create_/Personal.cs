using System;

using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.Operations;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace nilnul.fs.git.svr_.vs.client.teamwork.create_
{
	static public class _PersonalX
	{
		/// <summary>
		/// </summary>
		static public TeamProject Create(nilnul.fs.git.svr_.vs.Client org, string prjName, string description="")
		{
			var projectsSample = new _teamworks.LibConsumer(org);


			return projectsSample.createProject4private(
				prjName
			);

		}


		/// <summary>
		/// </summary>
		static public TeamProject Create(string org, string prjName, string description="")
		{
			return Create(  Client.CreateFroVault(org),prjName,description);

		}

	}
}


