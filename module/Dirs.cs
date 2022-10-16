using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// a folder that is the child of a root. this folder may be:
	/// ".git",
	/// "plain sub folder", 
	/// "subfolder that's the root of a submodule"
	/// 
	/// excluding the child of child.
	/// </summary>
	static public class _DirsX
	{
		/// <summary>
		/// .git or workspace 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="_rootChildFolder_Location"></param>
		/// <returns></returns>
		static public IEnumerable<string> Addresses(ModuleI module)
		{
			return nilnul.fs.folder._DirsX.Addresses(module.top.en);
		}
	}
}
