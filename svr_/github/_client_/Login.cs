using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github._client_
{
	/// <summary>
	/// 
	/// </summary>
	/* blog.somewhatabstract.com/tag/productheadervalue/
	 Now, if you only want to read information about publicly accessible repositories, you do not need to provide any authentication at all. You can create a client instance and just get stuck in, like this:
var githubClient = new GitHubClient(new ProductHeaderValue("Tinkering"));
var repo = await githubClient.Repository.Get("octokit", "octokit.net" );
Console.WriteLine(repo.Name);
However, you can only perform some read-only tasks on public repositories and, unless you are performing the most trivial of tasks, you will hit rate limits for unauthenticated access.
	*/
	public interface ILogin
	{

		

	}
}
