using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.head
{
	/// <summary>
	/// if head doesnot exits, git will complain that this is not a module.
	/// if head exists, it can:
	///		-) a branch
	///			which can:
	///				*) point to a commit. 
	///				*) does not exist in the refs/heads; This is empty branch.
	///		-) a commit
	///			this is detached.
	/// </summary>
	class ICategorize
	{
	}
}
