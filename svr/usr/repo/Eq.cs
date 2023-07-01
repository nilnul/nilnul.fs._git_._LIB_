using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo
{
	/// <summary>
	/// even for same svr connection, we might have different orgs. and the repo in each org is independent.
	/// We need this to make a set of distinct repoSvcEs.
	/// </summary>
	public class Eq
		:
		nilnul.obj.eq_.homo_.EqDefault<RepoI, string, nilnul.txt.eq_.CaseInsensitive>
		,
		IEqualityComparer<
			nilnul.fs.git.svr.client.RepoI
		>
	{

		//public bool Equals(RepoI x, RepoI y)
		//{

		//	return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
		//		x.basis,y.basis
		//	);
		//	//throw new NotImplementedException();
		//}

		//public int GetHashCode(RepoI obj)
		//{
		//	return nilnul.txt.eq_.CaseInsensitive
		//	throw new NotImplementedException();
		//}
		public Eq() : base(r=>r.basis)
		{
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}

	}
}
