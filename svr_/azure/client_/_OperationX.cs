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

//Microsoft.Azure.DevOps.ClientSamples.ProjectsAndTeams
{
	//[ClientSample(CoreConstants.AreaName, CoreConstants.ProjectsRouteName)]
	static public class _OperationX
	//: ClientSample
	{


		static public OperationsHttpClient GetClient(
			VssConnection _connection1
		)
		{
			return _connection1.GetClient<OperationsHttpClient>();


		}

		static public async Task<Operation> TimeoutForLongRunningAsyn_2interval8seconds_3due8seconds(
			OperationsHttpClient client
			,
			Guid operationId
			,
			int interavalInSec = 5
			,
			int maxTimeInSeconds = 60
			,
			CancellationToken cancellationToken = default   //(CancellationToken)
		)
		{

			DateTime expiration = DateTime.Now.AddSeconds(maxTimeInSeconds);
			//int checkCount = 0;

			while (true)
			{
				//Console.WriteLine(" Checking status ({0})... ", (checkCount++));

				Operation operation = await client.GetOperation(operationId, cancellationToken);

				if (!operation.Completed)
				{
					//Console.WriteLine("   Pausing {0} seconds", interavalInSec);

					await Task.Delay(interavalInSec * 1000);

					if (DateTime.Now > expiration)
					{
						throw new TimeoutException(String.Format("Operation did not complete in {0} seconds.", maxTimeInSeconds));
					}
				}
				else
				{
					return operation;
				}
			}
		}


		static public async Task<Operation> WaitForLongRunningAsyn_2seconds(
OperationsHttpClient operationsClient,
			Guid operationId
			,
			int interavalInSec = 5
			,
			CancellationToken cancellationToken = default(CancellationToken))
		{

			while (true)
			{
				//Console.WriteLine(" Checking status ({0})... ", (checkCount++));

				Operation operation = await operationsClient.GetOperation(operationId, cancellationToken);

				if (!operation.Completed)
				{
					//Console.WriteLine("   Pausing {0} seconds", interavalInSec);
					await Task.Delay(interavalInSec * 1000);

				}
				else
				{
					return operation;
				}
			}
		}
		//[ClientSampleMethod]




	}
}



