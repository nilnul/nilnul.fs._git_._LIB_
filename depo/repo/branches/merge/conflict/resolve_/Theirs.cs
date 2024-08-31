using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches.merge.conflict.resolve_
{
	/// <summary>
	/// If you're already in conflicted state...
	/// git checkout --theirs path/to/file
	/// 	If you're already in conflicted state, and you want to just accept all of theirs:
	/// 	git checkout --theirs.
	/// 	git add.
	/// 	This is pretty drastic, so make sure you really want to wipe everything out like this before doing it.
	/// </summary>
	class Theirs
	{
	}
}
