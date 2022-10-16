using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.nonrepo._work_.documents_
{
	/// <summary>
	/// excluding document, where some seg is dot led, eg:
	///		".gitignore" files
	///		".nilnul.ini"
	///		".git/"
	///		".nilnul/"
	///		"abc/.abd"
	///		"abc/.def/"
	///		"abc/.abd/def.aid"
	/// </summary>
	/// <remarks>
	/// in nilnul.dev.Bak, we go depth-first in iterating thru directory, and submodule would be inited. For those submodule that is <see cref="nilnul.fs.folder_.giT_.nonrepo.be_.wrought._AntoX"/>, that would have only dotLed, and wouldnot be listed here either.
	/// So this is compatible with our logic to not init nonwrought intending module.
	/// </remarks>
	static public class _NoDotLedX
	{
		static public IEnumerable<string> _Addresses_addressAssumeNonrepo(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var child in _work_.dirs_._NotDotLedX._DirInfoEs_addressAssumeModule(module))
			{
				foreach (var item in _work_.documents_._NoDotLedX._Addresses_assumeNonrepo(child))
				{
					yield return item;
				}

				//foreach (var item in _work_.directory.documents_._NoDotLedX._Addresses_ofNontopWork(child))
				//{
				//	yield return item;
				//}
			}

			foreach (var item in nilnul.fs.folder.docs_._NotDotLedX._Addresses_folderOfAddress(module))
			{
				yield return item;
			}

		}

		private static IEnumerable<string> _Addresses_assumeNonrepo(DirectoryInfo child)
		{
			return _Addresses_addressAssumeNonrepo(child.FullName);
		}

		public static IEnumerable<FileInfo> FileInfoS_ofAddress(string module
			,
			nilnul.win.prog_.Git git = null
			
			)
		{
			return _Addresses_addressAssumeNonrepo(module).Select(x => new FileInfo(x));
			//throw new NotImplementedException();
		}



	}
}
