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

namespace nilnul.fs.git.svr_.azure.client._teamworks

	//Microsoft.Azure.DevOps.ClientSamples.ProjectsAndTeams
{
	//[ClientSample(CoreConstants.AreaName, CoreConstants.ProjectsRouteName)]
	public class ConsumerFroMs
		//: ClientSample
	{
		VssConnection _connection1;

		int _defaultTimeout = 60;

		public ConsumerFroMs(nilnul.fs.git.svr_.azure.Client clientAzure)
		{

			//var org = "t"; //from env var
			//var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(org);

			//var clientAzure = new nilnul.fs.git.svr_.vs.Client(org,token);


			var personalAccessToken = clientAzure.token;//.token;// nilnul.win.app_._CredManX.Get(keyName);



			String c_collectionUri = clientAzure.spear();//. ; $"https://dev.azure.com/{org}";
			//String c_projectName = "t"+ Guid.NewGuid().ToString("N");// "MyGreatProject";
			//String c_repoName = c_projectName;// "MyRepo";

			// Interactively ask the user for credentials, caching them so the user isn't constantly prompted
			VssCredentials creds = new VssBasicCredential("", personalAccessToken);// VssClientCredentials();


			//creds.Storage = new VssClientCredentialStorage();

			// Connect to Azure DevOps Services
			VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);
			_connection1 = connection;
		}

		public ConsumerFroMs(string org, string token):this(
new nilnul.fs.git.svr_.azure.Client(org,token)
		)
		{

		}
		public ConsumerFroMs(string org):this(
 nilnul.fs.git.svr_.azure.Client.CreateFroVault(org)
		)
		{

		}

		public ConsumerFroMs():this(
 nilnul.fs.git.svr_.azure.Client.CreateFroVault()
		)
		{

			
		}

		/// <summary>
		/// set this before calling methods that would use this.
		/// </summary>

		public string org;
		/// <summary>
		/// Returns all team projects and the teams for each.
		/// </summary>
		/// <returns></returns>
		//[ClientSampleMethod]
		public Dictionary<TeamProjectReference, IEnumerable<WebApiTeam>> ListAllProjectsAndTeams()
		{
			//var org = "t"; //from env var
			var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(org);

			var clientAzure = nilnul.fs.git.svr_.azure.Client.CreateFroVault(org);


			var personalAccessToken = clientAzure.token;// nilnul.win.app_._CredManX.Get(keyName);



			String c_collectionUri = $"https://dev.azure.com/{org}";
			String c_projectName = "t"+ Guid.NewGuid().ToString("N");// "MyGreatProject";
			String c_repoName = c_projectName;// "MyRepo";

			// Interactively ask the user for credentials, caching them so the user isn't constantly prompted
			VssCredentials creds = new VssBasicCredential("", personalAccessToken);// VssClientCredentials();


			//creds.Storage = new VssClientCredentialStorage();

			// Connect to Azure DevOps Services
			VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);


			// Get the project and team clients
			//VssConnection connection = Context.Connection;

			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();
			TeamHttpClient teamClient = connection.GetClient<TeamHttpClient>();

			// Call to get the list of projects
			IEnumerable<TeamProjectReference> projects = projectClient.GetProjects().Result;

			Dictionary<TeamProjectReference, IEnumerable<WebApiTeam>> results = new Dictionary<TeamProjectReference, IEnumerable<WebApiTeam>>();

			// Iterate over the returned projects
			foreach (var project in projects)
			{
				// Get the teams for the project
				IEnumerable<WebApiTeam> teams = teamClient.GetTeamsAsync(project.Name).Result;

				// Add the project/teams item to the results dictionary
				results.Add(project, teams);

				Console.WriteLine(" " + project.Name);
				// Iterate over the teams and show the name
				foreach (var team in teams)
				{
					Console.WriteLine("    " + team.Name);
				}
			}

			if (projects.Count() == 0)
			{
				Console.WriteLine("No projects found.");
			}

			return results;
		}

		/// <summary>
		/// Returns only the first page of projects
		/// </summary>
		/// <returns></returns>
		//[ClientSampleMethod]
		public IEnumerable<TeamProjectReference> ListProjectsByPage()
		{

			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();


			int currentPage = 0;
			int pageSize = 3;
			int lastPageSize = -1;
			List<TeamProjectReference> allProjects = new List<TeamProjectReference>();
			do
			{
				// Get a single page of projects
				IEnumerable<TeamProjectReference> projects = projectClient.GetProjects(top: pageSize, skip: (currentPage * pageSize)).Result;

				// Add the set to the full list
				allProjects.AddRange(projects);

				lastPageSize = projects.Count();
				currentPage++;
				Console.WriteLine(currentPage);

				// Iterate and show the name of each project
				foreach (var project in projects)
				{
					Console.WriteLine(" " + project.Name);
				}
			}
			while (lastPageSize == pageSize);

			return allProjects;
		}

		//[ClientSampleMethod]
		public TeamProjectReference GetProjectDetails(string projectName)
		{
			//string projectName = "";// ClientSampleHelpers.FindAnyProject(this.Context).Name;

			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			// Get the details for the specified project
			TeamProject project = projectClient.GetProject(projectName, includeCapabilities: true, includeHistory: true).Result;

			// Get the "web" URL for this project
			ReferenceLink webLink = project.Links.Links["web"] as ReferenceLink;

			Console.WriteLine("Details for project {0}:", projectName);
			Console.WriteLine();
			Console.WriteLine("  ID          : {0}", project.Id);
			Console.WriteLine("  Description : {0}", project.Description);
			Console.WriteLine("  Web URL     : {0}", (webLink != null ? webLink.Href : "(not available)"));

			return project;
		}

		//[ClientSampleMethod]

		/// <summary>
		/// 
		/// </summary>
		/// <param name="projectName"></param>
		/// <param name="processName"></param>
		/// <returns></returns>
		/// <exception cref="">
		/// timeout exception
		/// </exception>
		public TeamProject createProject(
			string projectName
			,
			string description=""
			,
			string processName="Agile"
			,
			bool pub=false
		)
		{
			//string projectName = "Sample project " + Guid.NewGuid();
			string projectDescription = description;
			//string processName = "Agile";

			// Setup version control properties
			Dictionary<string, string> versionControlProperties = new Dictionary<string, string>();

			versionControlProperties[TeamProjectCapabilitiesConstants.VersionControlCapabilityAttributeName] =
				SourceControlTypes.Git.ToString();

			// Setup process properties       
			ProcessHttpClient processClient = this._connection1.GetClient<ProcessHttpClient>();// Context.Connection.GetClient<ProcessHttpClient>();
			Guid processId = processClient.GetProcessesAsync().Result.Find(process => { return process.Name.Equals(processName, StringComparison.InvariantCultureIgnoreCase); }).Id;

			Dictionary<string, string> processProperties = new Dictionary<string, string>();

			processProperties[TeamProjectCapabilitiesConstants.ProcessTemplateCapabilityTemplateTypeIdAttributeName] =
				processId.ToString();

			// Construct capabilities dictionary
			Dictionary<string, Dictionary<string, string>> capabilities = new Dictionary<string, Dictionary<string, string>>();

			capabilities[TeamProjectCapabilitiesConstants.VersionControlCapabilityName] =
				versionControlProperties;
			capabilities[TeamProjectCapabilitiesConstants.ProcessTemplateCapabilityName] =
				processProperties;

			// Construct object containing properties needed for creating the project
			TeamProject projectCreateParameters = new TeamProject()
			{
				Name = projectName,
				Description = projectDescription,
				Capabilities = capabilities
				,
				
				Visibility= pub? ProjectVisibility.Public : ProjectVisibility.Private
			};

			// Get a client
			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			TeamProject project = null;
			try
			{
				//Trace.WriteLine("Queuing project creation...");

				// Queue the project creation operation 
				// This returns an operation object that can be used to check the status of the creation
				OperationReference operation = projectClient.QueueCreateProject(projectCreateParameters).Result;

				//ClientSampleHttpLogger.SetSuppressOutput(Context, true);

				// Check the operation status every 5 seconds (for up to 30 seconds)
				Operation completedOperation = waitForLongRunningOperation(
					operation.Id
					,
					5
				).Result;

				// Check if the operation succeeded (the project was created) or failed
				if (completedOperation.Status == OperationStatus.Succeeded)
				{
					// Get the full details about the newly created project
					project = projectClient.GetProject(
						projectCreateParameters.Name,
						includeCapabilities: true,
						includeHistory: true).Result;

					//Trace.WriteLine("");
					//Trace.WriteLine($"Project created (ID: {project.Id.ToString()})" );

					// Save the newly created project (other sample methods will use it)
					//Context.SetValue<TeamProject>("$newProject", project);
				}
				else
				{
					throw new InvalidProjectCreateException(
"Project creation operation failed: " + completedOperation.ResultMessage
						);
					//Trace.WriteLine("Project creation operation failed: " + completedOperation.ResultMessage);
				}
			}
			catch (AggregateException ex)
			{
				ex.Handle(
					x =>  {
						if (x is InvalidProjectNameException t)
						{
							throw t;
						}
						return false;
					}
				);
				/*System.AggregateException
  HResult=0x80131500
  Message=发生一个或多个错误。
  Source=mscorlib
  StackTrace:
   at System.Threading.Tasks.Task`1.GetResultCore(Boolean waitCompletionNotification)
   at System.Threading.Tasks.Task`1.get_Result()
  

  This exception was originally thrown at this call stack:
    [External Code]

Inner Exception 1:
InvalidProjectNameException: TF50316: The following name is not valid: _t220822174620s8718404n8h. Verify that the name does not exceed the maximum character limit, only contains valid characters, and is not a reserved name.
*/

			}
			catch (Exception ex)
			{
				throw;
				//Trace.WriteLine("Exception during create project: ", ex.Message);
			}

			return project;
		}
		[Obsolete("prjName assume Normalized")]
		public TeamProject createProject4private(
			string projectName
			,
			string description = ""
			,
			string processName = "Agile"
		)
		{
			return _createProject4private_teamNameAssumeNormalized(projectName,description,processName);
		}



		public TeamProject _createProject4private_teamNameAssumeNormalized(
			string projectName
			,
			string description=""
			,
			string processName="Agile"
		)
		{
			//string projectName = "Sample project " + Guid.NewGuid();
			string projectDescription = description;
			//string processName = "Agile";

			// Setup version control properties
			Dictionary<string, string> versionControlProperties = new Dictionary<string, string>();

			versionControlProperties[TeamProjectCapabilitiesConstants.VersionControlCapabilityAttributeName] =
				SourceControlTypes.Git.ToString();

			// Setup process properties       
			ProcessHttpClient processClient = this._connection1.GetClient<ProcessHttpClient>();// Context.Connection.GetClient<ProcessHttpClient>();
			Guid processId = processClient.GetProcessesAsync().Result.Find(process => { return process.Name.Equals(processName, StringComparison.InvariantCultureIgnoreCase); }).Id;

			Dictionary<string, string> processProperties = new Dictionary<string, string>();

			processProperties[TeamProjectCapabilitiesConstants.ProcessTemplateCapabilityTemplateTypeIdAttributeName] =
				processId.ToString();

			// Construct capabilities dictionary
			Dictionary<string, Dictionary<string, string>> capabilities = new Dictionary<string, Dictionary<string, string>>();

			capabilities[TeamProjectCapabilitiesConstants.VersionControlCapabilityName] =
				versionControlProperties;
			capabilities[TeamProjectCapabilitiesConstants.ProcessTemplateCapabilityName] =
				processProperties;

			// Construct object containing properties needed for creating the project
			TeamProject projectCreateParameters = new TeamProject()
			{
				Name = projectName,
				Description = projectDescription
				,
				Visibility= ProjectVisibility.Private
				
				,
				Capabilities = capabilities
			};

			// Get a client
			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			TeamProject project = null;
			try
			{
				//Trace.WriteLine("Queuing project creation...");

				// Queue the project creation operation 
				// This returns an operation object that can be used to check the status of the creation
				OperationReference operation = projectClient.QueueCreateProject(projectCreateParameters).Result;

				//ClientSampleHttpLogger.SetSuppressOutput(Context, true);

				// Check the operation status every 5 seconds (for up to 30 seconds)
				Operation completedOperation = waitForLongRunningOperation(
					operation.Id
					,
					5
				).Result;

				// Check if the operation succeeded (the project was created) or failed
				if (completedOperation.Status == OperationStatus.Succeeded)
				{
					// Get the full details about the newly created project
					project = projectClient.GetProject(
						projectCreateParameters.Name,
						includeCapabilities: true,
						includeHistory: true).Result;

					//Trace.WriteLine("");
					//Trace.WriteLine($"Project created (ID: {project.Id.ToString()})" );

					// Save the newly created project (other sample methods will use it)
					//Context.SetValue<TeamProject>("$newProject", project);
				}
				else
				{
					throw new InvalidProjectCreateException(
"Project creation operation failed: " + completedOperation.ResultMessage
						);
					//Trace.WriteLine("Project creation operation failed: " + completedOperation.ResultMessage);
				}
			}
			catch (Exception ex)
			{
				throw;
				//Trace.WriteLine("Exception during create project: ", ex.Message);
			}

			return project;
		}

		public TeamProject createProject_timeout4result(
			string projectName
			,
			string processName="Agile"
		)
		{
			//string projectName = "Sample project " + Guid.NewGuid();
			string projectDescription = "Short description for my new project";
			//string processName = "Agile";

			// Setup version control properties
			Dictionary<string, string> versionControlProperties = new Dictionary<string, string>();

			versionControlProperties[TeamProjectCapabilitiesConstants.VersionControlCapabilityAttributeName] =
				SourceControlTypes.Git.ToString();

			// Setup process properties       
			ProcessHttpClient processClient = this._connection1.GetClient<ProcessHttpClient>();// Context.Connection.GetClient<ProcessHttpClient>();
			Guid processId = processClient.GetProcessesAsync().Result.Find(process => { return process.Name.Equals(processName, StringComparison.InvariantCultureIgnoreCase); }).Id;

			Dictionary<string, string> processProperties = new Dictionary<string, string>();

			processProperties[TeamProjectCapabilitiesConstants.ProcessTemplateCapabilityTemplateTypeIdAttributeName] =
				processId.ToString();

			// Construct capabilities dictionary
			Dictionary<string, Dictionary<string, string>> capabilities = new Dictionary<string, Dictionary<string, string>>();

			capabilities[TeamProjectCapabilitiesConstants.VersionControlCapabilityName] =
				versionControlProperties;
			capabilities[TeamProjectCapabilitiesConstants.ProcessTemplateCapabilityName] =
				processProperties;

			// Construct object containing properties needed for creating the project
			TeamProject projectCreateParameters = new TeamProject()
			{
				Name = projectName,
				Description = projectDescription,
				Capabilities = capabilities
			};

			// Get a client
			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			TeamProject project = null;
			try
			{
				Trace.WriteLine("Queuing project creation...");

				// Queue the project creation operation 
				// This returns an operation object that can be used to check the status of the creation
				OperationReference operation = projectClient.QueueCreateProject(projectCreateParameters).Result;

				//ClientSampleHttpLogger.SetSuppressOutput(Context, true);

				// Check the operation status every 5 seconds (for up to 30 seconds)
				Operation completedOperation = timeoutForLongRunningOperation(
					operation.Id, 5, _defaultTimeout).Result;

				// Check if the operation succeeded (the project was created) or failed
				if (completedOperation.Status == OperationStatus.Succeeded)
				{
					// Get the full details about the newly created project
					project = projectClient.GetProject(
						projectCreateParameters.Name,
						includeCapabilities: true,
						includeHistory: true).Result;

					Trace.WriteLine("");
					Trace.WriteLine($"Project created (ID: {project.Id.ToString()})" );

					// Save the newly created project (other sample methods will use it)
					//Context.SetValue<TeamProject>("$newProject", project);
				}
				else
				{
					Trace.WriteLine("Project creation operation failed: " + completedOperation.ResultMessage);
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine("Exception during create project: ", ex.Message);
			}

			return project;
		}

		private async Task<Operation> timeoutForLongRunningOperation(
			Guid operationId
			,
			int interavalInSec = 5
			,
			int maxTimeInSeconds = 60
			,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			OperationsHttpClient operationsClient = this._connection1.GetClient<OperationsHttpClient>();
			DateTime expiration = DateTime.Now.AddSeconds(maxTimeInSeconds);
			int checkCount = 0;

			while (true)
			{
				//Console.WriteLine(" Checking status ({0})... ", (checkCount++));

				Operation operation = await operationsClient.GetOperation(operationId, cancellationToken);

				if (!operation.Completed)
				{
					//Console.WriteLine("   Pausing {0} seconds", interavalInSec);

					await Task.Delay(interavalInSec * 1000);

					if (DateTime.Now > expiration)
					{
						throw new Exception(String.Format("Operation did not complete in {0} seconds.", maxTimeInSeconds));
					}
				}
				else
				{
					return operation;
				}
			}
		}

		private async Task<Operation> waitForLongRunningOperation(
			Guid operationId
			,
			int interavalInSec = 5
			
			,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			OperationsHttpClient operationsClient = this._connection1.GetClient<OperationsHttpClient>();

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
		public bool ChangeProjectDescription()
		{
			// Use the project created in the earlier "create project" sample method
			TeamProject project = null as TeamProject??throw new Exception();
			//if (!Context.TryGetValue<TeamProject>("$newProject", out project))
			//{
			//	Console.WriteLine("No previously created project to change the description of.");
			//	return false;
			//}

			TeamProject updatedProject = new TeamProject()
			{
				Description = "An event better description for my project!"
			};

			// Get a client
			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			Console.WriteLine("Queuing project update...");

			// Queue the update operation
			Guid updateOperationId = projectClient.UpdateProject(project.Id, updatedProject).Result.Id;

			//ClientSampleHttpLogger.SetSuppressOutput(Context, true);

			// Check the operation status every 2 seconds (for up to 30 seconds)
			Operation detailedUpdateOperation = timeoutForLongRunningOperation(updateOperationId, 2, 30).Result;

			// Check if the operation succeeded (the project was created) or failed
			if (detailedUpdateOperation.Status == OperationStatus.Succeeded)
			{
				Console.WriteLine();
				Console.WriteLine("Project description change from:\n {1}\nto\n {2}", project.Name, project.Description, updatedProject.Description);
				return true;
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine("Unable to change the description for project {0}", project.Name);
				return false;
			}
		}

		//[ClientSampleMethod]
		public bool RenameProject()
		{
			// Use the project created in the earlier "create project" sample method
			TeamProject project= ((TeamProject)null?? throw new Exception() );
			//if (!Context.TryGetValue<TeamProject>("$newProject", out project))
			//{
			//	Console.WriteLine("No previously created project to change the name of.");

			//	return false;
			//}

			// Get a client
			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			TeamProject updatedProject = new TeamProject()
			{
				Name = project.Name + " (renamed)"
			};

			Console.WriteLine("Queuing project update...");

			// Queue the update operation
			Guid updateOperationId = projectClient.UpdateProject(project.Id, updatedProject).Result.Id;

			//ClientSampleHttpLogger.SetSuppressOutput(Context, true);

			// Check the operation status every 2 seconds (for up to 30 seconds)
			Operation detailedUpdateOperation = timeoutForLongRunningOperation(updateOperationId, 2, 30).Result;

			if (detailedUpdateOperation.Status == OperationStatus.Succeeded)
			{
				Console.WriteLine();
				Console.WriteLine("Project renamed from:\n {0}\nto\n {1}", project.Name, updatedProject.Name);
				return true;
			}
			else
			{
				return false;
			}
		}

		//[ClientSampleMethod]
		public bool DeleteProject()
		{
			// Use the project created in the earlier "create project" sample method
			TeamProject project= null as TeamProject??throw new Exception();
			//if (!Context.TryGetValue<TeamProject>("$newProject", out project))
			//{
			//	Console.WriteLine("No previously created project found to delete.");

			//	return false;
			//}

			// Get a client
			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			Console.WriteLine("Queuing project delete...");

			// Queue the delete operation
			Guid operationId = projectClient.QueueDeleteProject(project.Id).Result.Id;

			//ClientSampleHttpLogger.SetSuppressOutput(Context, true);

			// Check the operation status every 2 seconds (for up to 30 seconds)
			Operation operationResult = timeoutForLongRunningOperation(operationId, 2, 30).Result;

			Console.WriteLine();
			Console.WriteLine("Delete project operation completed {0}", operationResult.Status);

			return operationResult.Status == OperationStatus.Succeeded;
		}

		/// <summary>
		/// List projects by their state. For example, only deleted projects.
		/// </summary>
		/// <returns></returns>
		//[ClientSampleMethod]
		public IEnumerable<TeamProjectReference> ListProjectsByState()
		{
			ProjectState state = ProjectState.Deleting;

			VssConnection connection = this._connection1;// Context.Connection;
			ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();

			// Get a list of all the projects with a state of "deleting"
			IEnumerable<TeamProjectReference> deletedProjects = projectClient.GetProjects(state).Result;

			foreach (var project in deletedProjects)
			{
				Console.WriteLine("  " + project.Name);
			}

			if (deletedProjects.Count() == 0)
			{
				Console.WriteLine("No projects with the state {0}", state);
			}

			return deletedProjects;
		}

	}
}



