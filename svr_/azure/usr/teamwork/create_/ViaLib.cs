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

namespace nilnul.fs.git.svr_.azure.client.teamwork.create_
{
	static public class _ByMsLibX
	{
		/// <summary>
		/// after more than 30 seconds, success.
		/// </summary>
		static public TeamProject Create(string prjName)
		{
			var projectsSample = new _teamworks.ConsumerFroMs();


			return projectsSample.createProject(
				prjName
			);

			 //var prjInfo = projectsSample.GetProjectDetails(
				// prjName
			 //);

		}

	}
}


