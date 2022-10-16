using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.neglect_
{
	/*--assume-unchanged assumes that a developer shouldn’t change a file. This flag is meant for improving performance for not-changing folders like SDKs.
--skip-worktree is useful when you instruct git not to touch a specific file ever because developers should change it. For example, if the main repository upstream hosts some production-ready configuration files and you don’t want to accidentally commit changes to those files, --skip-worktree is exactly what you want.*/
	class SkipWorktree
	{
	}
}
