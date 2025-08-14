using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.directory_.nonlink.dirs_
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// the dir itself is not symlink
	/// </summary>
	static public class _HardX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectoryUnLink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.folder_.giT_.work_.nontop.dirs_._NontopX._Addresses_addressAssumeNontop(
				workDirectoryUnLink, git
			).Where(
				nilnul.fs.folder.dir.be_.symlink._AntoX._Be_assumeAddressAsParented
			);
		}
	}
}
