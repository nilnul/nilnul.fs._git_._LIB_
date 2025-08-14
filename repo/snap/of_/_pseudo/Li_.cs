using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.snap.of_._pseudo
{
	/// <summary>
	/// Note that any of the refs/* cases may come either from the $GIT_DIR/refs directory or from the $GIT_DIR/packed-refs file. While the ref name encoding is unspecified, UTF-8 is preferred as some output processing may assume ref names in UTF-8.
	/// </summary>
	internal enum Li_
	{
		Head
			,
		Fetch_Head
			,
		Orig_Head
			,
		Merge_Head
			,
		Rebase_Head
			,
		Revert_Head
			,
		Cherry_Pick_Head
			,
		Bisect_Head
			,
		Auto_Merge
	}
}
