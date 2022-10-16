using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_.directory_.unLink.directories_
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
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var item 
				in 
				_work_.directory_.unLink.dirs_._UnLinkX.Addresses_ofAddress(
					workDirectoryUnLink, git
				)
			)
			{
				foreach (var item1 in divs_._UnLinkX.Addresses_ofAddress(item))
				{
					yield return item1;
				}

			} 
		}
	}
}
