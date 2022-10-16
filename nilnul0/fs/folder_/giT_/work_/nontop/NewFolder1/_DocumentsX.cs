using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory
{
    /// <summary>
    /// excluding :
    ///     documents in submodule
    /// </summary>
	///
	[Obsolete(nameof(nilnul.fs.folder_.giT_.work_.nontop.documents_._WithinWorkX))]
	static public class _DocumentsX
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nontopWork"></param>
        /// <returns></returns>
		public static IEnumerable<string> _OfNontopWork(string nontopWork)
		{

			foreach (
				var child in _work_.directory._DirsX.Addresses_ofAddress(
				    nontopWork
				)
			)
			{
					///sub
					foreach (var item in _OfNontopWork(child))
					{
						yield return item;
					}
				
			}

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

			foreach (var item in nilnul.fs.folder._DocsX.Infos_ofAddress(nontopWork))
			{
				yield return item.FullName;

			}

		}


	}
}
