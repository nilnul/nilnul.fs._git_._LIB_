using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gl.acc.repo
{
	[Obsolete()]
	static public class _UrlX
	{
		static public string Gen(string usr, nilnul.fs.git.svr.repo.Name repoName)
		{
			return $"https://gitlab.com/{usr}/{repoName}.git";
		}
	}
}