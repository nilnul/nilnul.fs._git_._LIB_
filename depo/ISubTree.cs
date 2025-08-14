namespace nilnul.fs.git.depo
{
	/// subtree is copy-based.
	///
	/// docs.github.com/en/get-started/using-git/about-git-subtree-merges
	///The "subrepository" is stored in a folder of the main repository.
	/// 
	/// <summary>
	///git subtree lets you nest one repository inside another as a sub-directory.
	/// 
	/// </summary>
	/// <remarks>
	/// git subtree does not add new metadata files like Git submodule does (i.e., .gitmodule).
	///git subtree does not require users of your repository to learn anything new. They can ignore the fact that you are using git subtree to manage dependencies.
	/// But:
	///		You must learn about a new merge strategy (i.e.git subtree).
	/// </remarks>
	/// vs:
	///		subrepo
	///		subdepo
	///		subtree
	///		submodule
	interface ISubTree { }
}
