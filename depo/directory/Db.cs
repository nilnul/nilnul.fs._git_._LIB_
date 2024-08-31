using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.directory
{
	/// <summary>
	/// the .git dir, which stores the state of a module
	/// </summary>
	static public class _DbX
	{
		/*For older versions (before 1.7.x), the other options are listed in "Is there a way to get the git root directory in one command?":
		git rev-parse --git-dir
		That would give the path of the.git directory.

		 .git if at the top
		 or absAddress(seemingly no ending slash) if at any directory
			 */
		/// <summary>
		/// 
		/// </summary>
		static public string _Address_ofDirectoryAddress(string _moduleDirectoryAddress, nilnul.win.prog_.Git git=null) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_moduleDirectoryAddress
				,
				"rev-parse --git-dir"
				,
				git
			);
		}
	}
}
