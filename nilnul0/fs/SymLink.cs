using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{
	/// <summary>
	/// Short version: there is no exact equivalent for POSIX symlinks on Windows, and the closest thing is unavailable for non-admins by default. 
	/// Therefore, symlink emulation support is switched off by default in Git4Win and needs to be configured by you, the user, via the core.symlinks=true config setting.
	/// </summary>
	public class SymLink
	{
	}
}
