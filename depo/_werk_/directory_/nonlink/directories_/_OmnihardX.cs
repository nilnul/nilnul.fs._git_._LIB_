using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.directory_.nonlink.directories_
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// </summary>
	///
	static public class _OmnihardX
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
				_werk_.directory_.nonlink.dirs_._HardX.Addresses_ofAddress(
					workDirectoryUnLink, git
				)
			)
			{
				foreach (var item1 in divs_._OmnihardX.Addresses_ofAddress(item))
				{
					yield return item1;
				}

			} 
		}
	}
}
