using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.bb.client_.cfged.repo
{
	[Obsolete("superseded by " + nameof(svr_.wellknown_.bb.client_.cfged.repo.url_._WithAccX) + " for url with no username brings errors")]
	static public class _UrlX
	{

		public static string Gen(string repoName)
		{
			return client.repo._UrlX.Gen(Cfged.Credential.UserName,repoName);
			//return $"https://{_ApiX.DOMAIN}/{Cfged.Credential.UserName}/{repoName}.git";

		}


	}
}
