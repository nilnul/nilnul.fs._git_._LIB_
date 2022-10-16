using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.nonrepo._work_.directory.documents_
{
    /// <summary>
    /// excluding :
    ///     documents in submodule
    /// </summary>
	static public class _NoDotLedX
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nontopWork"></param>
        /// <returns></returns>
		public static IEnumerable<string> _Addresses_ofNontopWork(string nontopWork)
		{

			foreach (
				var child in
				nilnul.fs.folder_.giT_.nonrepo._work_.dirs_._NotDotLedX._DirInfoEs_addressAssumeModule
				(
				    nontopWork
				)
			)
			{
					foreach (var item in _Addresses_ofNontopWork(child))
					{
						yield return item;
					}
			}

			foreach (var item in nilnul.fs.folder.docs_._NotDotLedX._Addresses_folderOfAddress(nontopWork))
			{
				yield return item;//.FullName;
			}
		}

		public static IEnumerable<string> _Addresses_ofNontopWork(DirectoryInfo child)
		{
			return _Addresses_ofNontopWork(
				child.FullName
			);
		}
	}
}