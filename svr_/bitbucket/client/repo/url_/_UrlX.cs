using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.bb.client.repo.url_
{
	static public class _WithAccX
	{

		public static string Gen(string userName,string repoName)
		{
			return $"https://{userName}@{svr_.bb._ApiX.DOMAIN}/{userName}/{repoName}.git";

		}


	}
}
