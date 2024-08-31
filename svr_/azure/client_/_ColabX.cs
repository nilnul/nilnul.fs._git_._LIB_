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

namespace nilnul.fs.git.svr_.azure.client_
{
	//[ClientSample(CoreConstants.AreaName, CoreConstants.ProjectsRouteName)]
	static public class _ColabX
	//: ClientSample
	{
	


		static public ProjectHttpClient GetClient(VssConnection connection)
		{


			// Get a client
			;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();
			return projectClient;


		}


	}
}



