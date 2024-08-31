namespace nilnul.fs.git.depo.repo
{

	/// <summary>
	/// like HEAD or ORIG_HEAD
	/// </summary>
	/// <remarks>
	/// A symbolic ref is a regular file that stores a string that begins with ref: refs/. For example, your .git/HEAD is a regular file whose content is ref: refs/heads/master
	/// </remarks>
	/// alias:
	///		pseudoReference
	///		symbolic-ref
	interface IPseudoRefer
	{
		/*
		<refname>, e.g.master, heads/master, refs/heads/master
A symbolic ref name.E.g.master typically means the commit object referenced by refs/heads/master.If you happen to have both heads/master and tags/master, you can explicitly say heads/master to tell Git which one you mean.When ambiguous, a<refname> is disambiguated by taking the first match in the following rules:

If $GIT_DIR/<refname> exists, that is what you mean (this is usually useful only for HEAD, FETCH_HEAD, ORIG_HEAD, MERGE_HEAD and CHERRY_PICK_HEAD);
		*/
	}
}
