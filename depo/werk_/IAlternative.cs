using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk_
{
	///git-scm.com/docs/git-worktree
	/// <summary>
	/// This new worktree is called a "linked worktree" as opposed to the "main worktree" prepared by git-init or git-clone. A repository has one main worktree (if it’s not a bare repository) and zero or more linked worktrees. When you are done with a linked worktree, remove it with git worktree remove.
	/// </summary>
	/// 
	/// 
	internal class IAlternative
	{
		/*
stackoverflow.com/questions/2383754/git-how-do-you-add-an-external-directory-to-the-repository

		git --work-tree=/ add /home/some/directory
		 */

		/*
stackoverflow.com/questions/5283262/what-is-git-work-tree-why-have-i-never-needed-to-set-this-env-var-why-now
		
		 fatal: GIT_WORK_TREE (or --work-tree=<directory>) not allowed without specifying GIT_DIR (or --git-dir=<directory>)
		 */


		/*GIT_COMMON_DIR */
	}
}
