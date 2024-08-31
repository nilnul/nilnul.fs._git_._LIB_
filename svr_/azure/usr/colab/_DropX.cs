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

namespace nilnul.fs.git.svr_.azure.usr.colab

//Microsoft.Azure.DevOps.ClientSamples.ProjectsAndTeams
{
	//[ClientSample(CoreConstants.AreaName, CoreConstants.ProjectsRouteName)]
	static public class _DropX
	//: ClientSample
	{
	
		static public Guid DroppingProject( ProjectHttpClient client, Guid project)
		{



			// Queue the delete operation
			Guid operationId = client.QueueDeleteProject(project).GetAwaiter().GetResult().Id;// Result.Id;

			return operationId;

			
		}
		static public Guid DroppingProject(ProjectHttpClient client, TeamProject project)
		{

			return DroppingProject(
				client, project.Id
			);


		}

	
		static public void DropProject( ProjectHttpClient client, Guid project, OperationsHttpClient opClient)
		{

			//TeamProject
			//project= null as TeamProject??throw new Exception();
			//if (!Context.TryGetValue<TeamProject>("$newProject", out project))
			//{
			//	Console.WriteLine("No previously created project found to delete.");

			//	return false;
			//}

			// Get a client



			// Queue the delete operation
			Guid operationId = DroppingProject(client, project);// client.QueueDeleteProject(project).GetAwaiter().GetResult().Id;// Result.Id;

			//ClientSampleHttpLogger.SetSuppressOutput(Context, true);

			// Check the operation status every 2 seconds (for up to 30 seconds)
			Operation operationResult = client_._OperationX.TimeoutForLongRunningAsyn_2interval8seconds_3due8seconds(opClient, operationId, 2, 30).GetAwaiter().GetResult();//.Result;

			//Console.WriteLine();
			//Console.WriteLine("Delete project operation completed {0}", operationResult.Status);

			if (operationResult.Status != OperationStatus.Succeeded)
			{
				throw new InvalidOperationException(
					$"removing project:{project} failed"
				);
			}

			//return operationResult.Status == OperationStatus.Succeeded;
		}





	}
}



