using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.client.repo
{
	static public class _UrlX
	{
		[Obsolete(nameof(_Url_repoAssumeNormalized))]
		static public string _Gen(string prefix, string repo)
		{
			return $"https://{prefix}.visualstudio.com/DefaultCollection/_git/{repo}";
		}

		static public string _Url_repoAssumeNormalized(string prefix, string repo)
		{
			return $"https://{prefix}.visualstudio.com/DefaultCollection/_git/{repo}";
		}


		static public string Gen(string prefix, vs.repo.Name repo)
		{
			return _Url_repoAssumeNormalized(prefix, repo);
		}
		static public string Url_ofOrg(string prefix, vs.repo.Name repo)
		{
			return _Url_repoAssumeNormalized(prefix, repo);
		}

		static public string Url_ofOrg(string prefix, string repo)
		{
			return Url_ofOrg(prefix
				,
				 vs.repo.Name.ByEncode(repo)
			);
		}
		static public string _Url(string prefix, string repo)
		{
			return Gen(prefix, vs.repo.Name.ByEncode(repo));
		}

	}
}
