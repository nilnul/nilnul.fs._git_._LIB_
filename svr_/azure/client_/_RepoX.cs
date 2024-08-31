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
using Microsoft.TeamFoundation.SourceControl.WebApi;

namespace nilnul.fs.git.svr_.azure.client_
{
	static public class _RepoX
	{
	


		static public GitHttpClient GetClient(VssConnection connection)
		{


			return connection.GetClient<GitHttpClient>();


		}


	}
}



