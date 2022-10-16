using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.bitBucket.api.repos.user
{
	public class Repo
	{
		static public string CreateUrl2_0_(string username,string repo_slug) {
			return $"{repos.Username.CreateUrl2_0(username)}/{repo_slug}";
		}


	}
}
