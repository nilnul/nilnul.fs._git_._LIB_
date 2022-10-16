using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs_.prefixed.client._repo
{
	static public class _ApiX
	{
		static public string GenUrl(string account, string version)
		{
			return	Client.GenerateUrl(account, "git/repositories", version);
		}
	}
}
