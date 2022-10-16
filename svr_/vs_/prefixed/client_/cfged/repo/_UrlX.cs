using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs_.prefixed.client_.cfged.repo
{
	static public class _UrlX
	{
		static public string Gen( string repo)
		{
			return Gen(  vs.repo.Name.ByEncode(repo) );
		}

		static public string Gen( vs.repo.Name repo)
		{
			return client.repo._UrlX.Gen( nilnul.fs.git.Properties.Settings.Default.svr_vs__prefix,repo);
		}

	}
}
