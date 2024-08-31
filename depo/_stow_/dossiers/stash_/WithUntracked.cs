using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.dossiers.stash_
{
	/// <summary>
	/// by default git stash only stashes changes to files that are tracked by Git, ignores ignored files.
	/// However, you can invoke git stash with the
	///		--all
	///		,or -a
	///		,option to stash changes to untracked (including ignored) files as well.
	/// </summary>
	internal class WithUntracked
	{
	}

}
