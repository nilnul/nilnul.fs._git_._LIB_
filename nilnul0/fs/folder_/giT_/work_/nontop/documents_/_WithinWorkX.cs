using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.documents_
{
    /// <summary>
    /// excluding :
    ///     documents in submodule
    /// </summary>
	static public class _WithinWorkX
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nontopWork"></param>
        /// <returns></returns>
		public static IEnumerable<string> _OfNontopWork(
			string nontopWork
			,
			nilnul.win.prog_.Git git=null
		)
		{

			return divs_._NontopX._Addresses_addressAssumeNontop(
				nontopWork
				,git
			).SelectMany(
				div=> System.IO.Directory.EnumerateFiles(div)
			);

			//foreach (
			//	var child in _work_.directory._DirsX.Addresses_ofAddress(
			//	    nontopWork
			//	)
			//)
			//{
			//		///sub
			//		foreach (var item in _OfNontopWork(child))
			//		{
			//			yield return item;
			//		}
				
			//}

			//foreach (
			//	var child in nilnul.fs.folder.dirs.as_._ChildsX.AddressTxtS(
			//	nontopWork
			//	)
			//)
			//{
			//	if (!nilnul.fs.folder_.git_.work.be_._TopX._Be(child))
			//	{
			//		///sub
			//		foreach (var item in _OfNontopWork(child))
			//		{
			//			yield return item;
			//		}
			//	}
			//}

			//foreach (var item in nilnul.fs.folder._DocsX.Infos_ofAddress(nontopWork))
			//{
			//	yield return item.FullName;

			//}

		}


	}
}
