using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_
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
	static public class _NoDotLedX
	{
		static public IEnumerable<string> _Addresses_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.folder_.giT_.work_.top.divs_.noDotLed_._WithinWorkX._Addresses_addressAssumeTop(
				module, git
			).SelectMany(
				x => nilnul.fs.folder.docs_._NotDotLedX._Addresses_folderOfAddress(x)
			);

			//foreach (var child in _work_.dirs_._NotDotLedX._DirInfoEs_addressAssumeModule(module))
			//{
			//	foreach (var item in _work_.directory.documents_._NoDotLedX._Addresses_ofNontopWork(child))
			//	{
			//		yield return item;
			//	}
			//}

			//foreach (var item in nilnul.fs.folder.docs_._NotDotLedX._Addresses_folderOfAddress(module))
			//{
			//	yield return item;
			//}

		}
		public static IEnumerable<FileInfo> FileInfoS_ofAddress(string module
			,
			nilnul.win.prog_.Git git = null
			
			)
		{
			return _Addresses_ofAddress(module).Select(x => new FileInfo(x));
			//throw new NotImplementedException();
		}

		static public IEnumerable<string> Addresses(
			nilnul.fs.folder_.git_.work_.Top module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Addresses_ofAddress(module.en.address.ToString(),git);
		}

		static public IEnumerable<string> Addresses(
			nilnul.fs.git._module_.TopI1 module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Addresses_ofAddress(module.top1.en.address.ToString(),git);
		}

	}
}
