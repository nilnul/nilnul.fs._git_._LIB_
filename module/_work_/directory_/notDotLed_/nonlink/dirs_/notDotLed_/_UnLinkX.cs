using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory_.notDotLed_.nonlink.dirs_.notDotLed_
{
	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(fs.folder_.giT_.work_.nontop.dirs_.notDotLed_.nonlink_._NontopX))]
	static public class _UnlinkX
	{

		static public IEnumerable<DirectoryInfo> _Infos_addressAssumeNontop(
			DirectoryInfo workDirectoryUnLink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return fs.folder_.giT_.work_.nontop.dirs_.notDotLed_.nonlink_._NontopX._Infos_assumeNontop(
				workDirectoryUnLink
				,
				git
			);

			//return _work_.directory._DirsX.Addresses_ofAddress(
			//	workDirectoryUnLink, git
			//).Where(
			//	nilnul.fs.folder.dir.be_.symlink._AntoX._Be_assumeAddressAsParented
			//);
		}
		static public IEnumerable<DirectoryInfo> _Infos_addressAssumeNontop(
			string workDirectoryUnLink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Infos_addressAssumeNontop(
				new DirectoryInfo(workDirectoryUnLink)
				,
				git
			);

			//return _work_.directory._DirsX.Addresses_ofAddress(
			//	workDirectoryUnLink, git
			//).Where(
			//	nilnul.fs.folder.dir.be_.symlink._AntoX._Be_assumeAddressAsParented
			//);
		}


	}
}
