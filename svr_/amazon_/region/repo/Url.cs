using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.amazon_.region.repo
{
	static public class _UrlX
	{
		static public string Url(string region, string repoName) {
			return $"{_RegionX.Origion(region)}/v1/repos/{repoName}";

		}
	}
}
