using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.fetch_.brancH_
{
	/// <summary>
	/// 
	/// </summary>
	class Noncurrent
	{

		/*
		https://stackoverflow.com/questions/3216360/merge-update-and-pull-git-branches-without-using-checkouts

		You cannot merge a branch B into branch A without checking out A first if it would result in a non-fast-forward merge. This is because a working copy is needed to resolve any potential conflicts.

		 If you want the fetch command to fail if the update is non-fast-forward, then you simply use a refspec of the form

git fetch <remote> <remoteBranch>:<localBranch>
If you want to allow non-fast-forward updates, then you add a + to the front of the refspec:

git fetch <remote> +<remoteBranch>:<localBranch>
Note that you can pass your local repo as the "remote" parameter using .:

git fetch . <sourceBranch>:<destinationBranch>
		 */
	}
}
