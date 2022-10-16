using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs_.prefixed.repo
{
	static public class _UrlX
	{

		static public string Gen(string prefix, vs.repo.Name repo)
		{
			return $"https://{prefix}.visualstudio.com/DefaultCollection/_git/{repo}";
		}
		/// <summary>
		/// starting "_" is not allowed. we escape this.
		/// </summary>
		/// <param name="prefix"></param>
		/// <param name="repo"></param>
		/// <returns></returns>
		static public string Gen(string prefix, string repo)
		{
			return Gen(prefix,  vs.repo.Name.ByEncode(repo));
		}

	}
}
