using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.noDotLed_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	static public class _NonlinkX
	{
		static public IEnumerable<string> _Addresses_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.folder_.giT_.work_.top.divs_.noDotLed_.nonlink_._WithinWorkX._Addresses_addressAssumeTop(
				module, git
			).SelectMany(
				x => nilnul.fs.folder.docs_.notDotLed_._NonlinkX._AddressTxts_ofFolderAddress(x)
			);

		


		}
		static public IEnumerable<FileInfo> _Infos_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.folder_.giT_.work_.top.divs_.noDotLed_.nonlink_._WithinWorkX._Addresses_addressAssumeTop(
				module, git
			).SelectMany(
				x => nilnul.fs.folder.docs_.notDotLed_._NonlinkX.AsFileInfoS_ofAddress(x)
			);

			//foreach (
			//	var item in fs.folder_.giT_.work_.top.divs_.noDotLed_.nonlink_._WithinWorkX._Addresses_addressAssumeTop(module,git)
			//)
			//{
			//	foreach (var doc in
			//		nilnul.fs.folder.docs_.notDotLed_._NonlinkX.AsFileInfoS_ofAddress(item)
			//	)
			//	{
			//		yield return doc;

			//	}
			//}


		}
		public static IEnumerable<FileInfo> FileInfoS_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
			
			)
		{
			return _Infos_addressAssumeModule(module);//.Select(x => new FileInfo(x));
			//throw new NotImplementedException();
		}

		static public IEnumerable<FileInfo> Addresses(
			nilnul.fs.folder_.git_.work_.Top module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Infos_addressAssumeModule(module.en.address.ToString(),git);
		}

		static public IEnumerable<FileInfo> Addresses(
			nilnul.fs.git._module_.TopI1 module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Infos_addressAssumeModule(module.top1.en.address.ToString(),git);
		}

	}
}
