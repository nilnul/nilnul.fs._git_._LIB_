using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gl.client_.cfged.repo
{
	static public class _UrlX
	{
		static public string Gen( nilnul.fs.git.svr.repo.Name repoName)
		{
			return gl.acc.repo._UrlX.Gen(_CfgedX.Ensure().UserName, repoName);
		}
	}
}