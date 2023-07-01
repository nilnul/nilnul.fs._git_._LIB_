using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_
{
	/*
	///github.blog/2020-07-27-highlights-from-git-2-28/
	/// Starting in Git 2.28, git init will instead look to the value of init.defaultBranch when creating the first branch in a new repository. If that value is unset, init.defaultBranch defaults to master. Here, it’s important to note that: 
	/// This configuration variable can be set by the user, and overriding the default value is as easy as:
	/// $ git config --global init.defaultBranch main
	/// 
	///This configuration variable only affects new repositories, and does not cause branches in existing projects to be renamed. git clone will also continue to respect the HEAD of the repository you’re cloning from, so you won’t see a change in branch names until a maintainer initiates one.
	*/

	/// <summary>
	/// The default branch is the first branch that Git will check out on a fresh clone. Also, pull requests target this branch by default.
	/// </summary>
	/// <remarks>
	/// Git 2.28 added the ability to choose an initial branch name.
	///Previously, the default branch was almost always named master. The most popular alternative name is main. Less common options include trunk and development. or bak, as nilnul.dev.src.bak does?
	///Absent any restrictions from the tools you use or team you're on, any valid branch name will work.
	/// </remarks>
	static public class _DefaultX
	{
		public const string MASTER = "master";

		/// <summary>
		/// </summary>
		public const string MAIN = "master";

	}
}
