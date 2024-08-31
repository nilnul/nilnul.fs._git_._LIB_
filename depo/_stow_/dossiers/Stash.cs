using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.dossiers
{
	/// <summary>
	/// By default, running git stash will stash:
	/// changes that have been added to your index (staged changes)
	/// changes made to files that are currently tracked by Git (unstaged changes)
	/// But it will not stash:
	///		new files in your working copy that have not yet been staged
	///		,files that have been ignored
	/// </summary>
	internal class Stash
	{
	}
}
