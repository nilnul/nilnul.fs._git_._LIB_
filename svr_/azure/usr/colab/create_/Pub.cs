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
	static public class _PubX
	{
		/// <summary>
		/// </summary>
		static public TeamProject Create(nilnul.fs.git.svr_.azure.Client org, nilnul.fs.git.svr_.azure.repo.Name prjName, string description="")
		{
			var projectsSample = new _teamworks.ConsumerFroMs(org);


			return projectsSample.createProject(
				prjName
				,description,pub:true
			);

		}

		/// <summary>
		/// </summary>
		static public TeamProject Create(nilnul.fs.git.svr_.azure.Client org, string prjName, string description="")
		{

			return Create(org, nilnul.fs.git.svr_.azure.repo.Name.ByEncode(prjName) ,description);

		}

		static public TeamProject _Create_prjNameAssumeNormed(nilnul.fs.git.svr_.azure.Client org, string prjName, string description="")
		{

			return Create(org, new nilnul.fs.git.svr_.azure.repo.Name(prjName) ,description);

		}


		/// <summary>
		/// </summary>
		static public TeamProject Create(string org, string prjName, string description="")
		{
			return Create(  Client.CreateFroVault(org),prjName,description);

		}

	}
}


