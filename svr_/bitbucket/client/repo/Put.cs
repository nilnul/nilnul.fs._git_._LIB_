using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bitBucket.client.repo
{
	/// <summary>
	/// /rest/api/1.0/projects/{projectKey}/repos/{repositorySlug}
	/// </summary>
	public class _PutX
	{
		public const string Name = "repositories";

		public static readonly string Url_1_0_ = $"{BitBucket.url1_0}/{Name}";

		public static string GetUrl(string repoName) {
			return $"{Url_1_0_}/{repoName}";
		}




	}
}
