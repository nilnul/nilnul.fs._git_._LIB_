using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.sortie_
{
	/// <summary>
	/// a sortie of host, distinct by host. useful for bakking or publishing.
	/// </summary>
	///
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]

	public class ByHost
		:
		nilnul.obj.sortie_.EqDefault1<
			nilnul.fs.git.svr.client.RepoI
			,
			nilnul.fs.git.svr.client.repo.eq_.ByHost
		>
	{
		public ByHost(ObjsI3<RepoI> val) : base(val)
		{
		}

		public ByHost(IEnumerable<RepoI> val) : base(val)
		{
		}

		public ByHost(params RepoI[] elements) : base(elements)
		{
		}
		public ByHost():base()
		{

		}


	}
}
