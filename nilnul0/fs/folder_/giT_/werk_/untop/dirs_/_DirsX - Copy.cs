using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory.dirs_
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// </summary>
	static public class _UnLinkX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectoryUnLink
			,
			nilnul.win.program_.Git git = null
		)
		{
			return _work_.directory._DirsX.Addresses_ofAddress(
				workDirectoryUnLink, git
			).Where(
				nilnul.fs.folder.be_.Normal.Singleton.be_ofAddress
			);
		}
	}
}
