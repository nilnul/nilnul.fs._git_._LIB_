using nilnul.web._url._origin._authority._socket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.eq_
{
	public class ByHost
		:
		nilnul.obj.eq_.homo_.EqDefault<
			RepoI
			,
			HostI1
			,
			nilnul.web._url._origin._authority._socket.host.Eq1
			//nilnul.txt.eq_.CaseInsensitive
			>
		,
		IEqualityComparer<
			nilnul.fs.git.svr.client.RepoI
		>
	{
		public ByHost() : base(
			r=>nilnul.web.url._ParseX4.Parse( r.basis).origin.authority.socket.host
		)
		{
		}
	}
}
