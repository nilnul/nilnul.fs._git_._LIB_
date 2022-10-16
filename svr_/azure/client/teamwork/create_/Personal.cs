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
	static public class _PersonalX
	{
		static public TeamProject _Create_teamNameAssumeNormalized(nilnul.fs.git.svr_.azure.Client org, string prjName, string description="")
		{
			var projectsSample = new _teamworks.ConsumerFroMs(org);


			return projectsSample._createProject4private_teamNameAssumeNormalized(
				prjName
			);

		}

		static public TeamProject _Create_teamNameAssumeNormalized(string org, string prjName, string description="")
		{
			return _Create_teamNameAssumeNormalized(  Client.CreateFroVault(org),prjName,description);

		}

		/// <summary>
		/// </summary>
		[Obsolete( "prjName assume normalized" )]
		static public TeamProject Create(string org, string prjName, string description="")
		{
			return _Create_teamNameAssumeNormalized (  Client.CreateFroVault(org),prjName,description);

		}
		/// <summary>
		/// </summary>
		///
		[Obsolete("prjName assume normalized")]
		static public TeamProject Create(nilnul.fs.git.svr_.azure.Client org, string prjName, string description = "")
		{
			return _Create_teamNameAssumeNormalized(org,prjName,description);
			var projectsSample = new _teamworks.ConsumerFroMs(org);


			return projectsSample.createProject4private(
				prjName
			);

		}



	}
}


