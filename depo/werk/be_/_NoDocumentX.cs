using System.Linq;
using nilnul.fs._address.dst;
using nilnul.obj.seq.be_;

namespace nilnul.fs.git.module.work.be_
{
	/// <summary>
	/// no docs. There might be some empty folders.
	/// </summary>
	/// alias:
	///		bald
	///		nodocument
	static public class _NoDocumentX
	{
		static public bool Be(nilnul.fs.folder_.git_.work_.Top work) {
			return nilnul.fs.git.module._work_._DocumentsX.Addresses(work).None();

			//var dsts = nilnul.fs.folder._Dsts.Dsts(work.en).Take(2);
			//return dsts.Count()==1 && nilnul.fs._address.dst.Eq.Singleton.Eq(
			//	dsts.First() 
			//	,
			//	".git"
			//);
		}

		
	}
}
