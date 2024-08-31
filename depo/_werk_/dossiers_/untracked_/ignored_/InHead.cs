using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.untracked_.ignored_
{
	/// <summary>
	/// if a file is in repo head, but not in index (due to say, removal),
	/// and now if it's in werk,
	///		if it is ignored, then it is not shown in untracked when run by "git status"
	/// </summary>
	internal class InHead:IIgnored
	{
	}

}
