using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.directory.dir.be_
{
	/// <summary>
	/// This folder is the child folder of a nonRootWork.
	///	This folder is one of:
	///		* nonrootWork
	///		* rootWork
	/// </summary>
	static public class _TopX
	{
		static public bool _Be(
			Git git
			,
			string _location__nonrootWork_child
		)
		{

			return nilnul.fs.git.module.Workspace._IsRoot(git, _location__nonrootWork_child);

		}
	}
}
