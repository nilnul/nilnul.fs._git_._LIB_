using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.snap.tree
{
	///matthew-brett.github.io/curious-git/git_object_types.html
	/// <summary>
	/// The object types in a directory listing are almost invariably either “blob” or “tree”, but can also be “commit” for recording the commit of a git submodule 
	/// </summary>
	/// git ls-tree -l -r <commit>
	///		,where l means long, the file size.
	///		, r means recursive into subdir;
	internal class Entries
	{
	}
}
