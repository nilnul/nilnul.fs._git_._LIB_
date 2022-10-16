using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_.directory
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// </summary>
	static public class _DirsX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectory
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var child in Directory.EnumerateDirectories(workDirectory))
			{
				if (
					nilnul.fs.git.module.dir_.work.be_._NonTopX._Be(child, git)
				)
				{
					yield return child;
				}
			}
		}
	}
}
