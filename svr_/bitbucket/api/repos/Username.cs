using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.bitBucket.api.repos
{
	public class Username
	{
		static public string CreateUrl2_0(string username) {
			return $"{bitBucket.Repos.Url_2_0_}/{username}";
		}
	}
}
