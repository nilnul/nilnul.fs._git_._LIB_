using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory_.unLink.divs_
{
	/// <summary>
	/// not repo;
	/// not submodule;
	/// </summary>
	static public class _UnLinkX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectoryUnlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var directory in directories_._UnLinkX.Addresses_ofAddress(workDirectoryUnlink))
			{
				yield return directory;
			}
			yield return workDirectoryUnlink;
		}
	}
}
