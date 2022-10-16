using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.svr_.vs
{
	public class Repos
	{
		static public string GenerateUrl1(string account, string version)
		{

			return


			VisualStudio.GenerateUrl(account, "git/repositories", version);
		}
	}
}
