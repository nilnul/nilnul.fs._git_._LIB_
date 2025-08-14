using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote
{
	/*
	 https://stackoverflow.com/questions/61330906/how-can-we-keep-all-pull-requests-and-their-respective-commits-locally-in-github

Yes, it's possible to pull all the pull requests individually to your branch. GitHub has the refs refs/pull/* /head, so that refs/pull/1/head is the HEAD for pull request 1. Note that issues and pull requests share numbering, so numbers may not be sequential.

This also only pulls down the branch, and not any of the metadata that goes along with it, such as reviews or comments. You can access that the GitHub CLI or API if you want.

To pull those references, you'd adjust the appropriate remote section of your .git/config:
	*/

////[remote "origin"]
////    url = https://github.com/git-lfs/git-lfs.git
////    fetch = +refs/heads/*:refs/remotes/origin/*
////    # Add the line below.

////    fetch = +refs/pull/*/head:refs/remotes/origin/pull/*/head
////Note that you almost certainly don't want to delete or replace the ref/heads/* line, but add an additional one instead.
		
	/**/

	/// <summary>
	///  the meta data such as reviews or comments are not fetched.
	/// </summary>
	internal class IRefers
	{
	}
}
