using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// another module in the work of the module.
	/// </summary>
	/// <remarks>
	/// vs:
	///		submodule
	///			is mutual cognostic to the base module whileas nest module is independent, manually created by usr.
	///			involves gitlink
	///		subtree
	///			Unlike submodules, subtrees do not need any special	constructions(like.gitmodule files or gitlinks) be present in your repository, and do not force end-users of your repository to do anything special or to understand how subtrees work.A subtree is just a subdirectory that can be committed to, branched, and merged along with your project in any way you want
	///			is copy while submodule is link
	///			for code and history reuse
	///			pushing a main repo to remote pushes sub-tree's files
	///			provides a front-end to git's built-in subtree merge strategy. It is better when you prefer to have a single-repository "unified" git history.
	///		subtree merge strategy
	///			which is different from subtree.
	/// </remarks>
	/// https://github.com/apenwarr/git-subtree/blob/master/git-subtree.txt
	/// 
	class INested
	{
	/*
	Its parent repo will see it as a gitlink (a special entry in its index, representing a SHA1) 
	 
	 The problem is: that SHA1 reference has no URL reference, so cloning again the parent repo will lead to an empty folder, because the parent repo does not know where to search for the nested Git repo.
	This differ from a submodule, which records the gitlink (same as a nested repo) and the URL of the nested repo (in a special file: .gitmodules)
If your parent repo ignore (in a .gitignore) the nested repo enntry, then both can co-exist without issue.

stackoverflow.com/questions/54897439/whats-wrong-with-nested-git-repos
Feb 27, 2019 at 5:39
VonC
	 */



	}

}
