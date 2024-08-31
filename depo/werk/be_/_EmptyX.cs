using System.Linq;
using nilnul.fs._address.dst;
using nilnul.obj.seq.be_;

namespace nilnul.fs.git.module.work.be_
{
	/// <summary>
	/// no dsts
	/// no docs. nodirs.
	/// </summary>
	/// alias:
	///		nodsts.
	///		clear
	///		
	static public class _EmptyX
	{
		static public bool Be(nilnul.fs.folder_.git_.work_.Top work) {
			return nilnul.fs.git.module._work_._DstsX.Addresses(work).None();

			//var dsts = nilnul.fs.folder._Dsts.Dsts(work.en).Take(2);
			//return dsts.Count() == 1 && nilnul.fs._address.dst.Eq.Singleton.Eq(
			//	dsts.First()
			//	,
			//	".git"
			//);
		}

		
	}
}
