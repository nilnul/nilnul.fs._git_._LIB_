using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.documents_.notDotLed_.nonlink_
{
    /// <summary>
    /// </summary>
	static public class _WithinWorkX
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nontopWork"></param>
        /// <returns></returns>
		public static IEnumerable<string> _Addresses_ofNontopWork(
			string nontopWork
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return nilnul.fs.folder_.giT_.work_.nontop.divs_.noDotLed_.nonlink_._NontopX._Addresses_addressAssumeNontop(
				nontopWork,git
			)
			.SelectMany(
				f=>
				nilnul.fs.folder.docs_.notDotLed_._NonlinkX._AddressTxts_ofFolderAddress(f)
			);

			//foreach (
			//	var child in
			//	nilnul.fs.folder_.giT_.work_.nontop.dirs_.nontop_._NotDotLedX.Addresses_ofAddress
			//	(
			//	    nontopWork
			//	)
			//)
			//{
			//		foreach (var item in _Addresses_ofNontopWork(child))
			//		{
			//			yield return item;
			//		}
			//}

			//foreach (var item in nilnul.fs.folder.docs_._NotDotLedX._Addresses_folderOfAddress(nontopWork))
			//{
			//	yield return item;//.FullName;
			//}
		}

		public static IEnumerable<string> _Addresses_ofNontopWork(
			DirectoryInfo child
						,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Addresses_ofNontopWork(
				child.FullName
				,
				git
			);
		}
	}
}