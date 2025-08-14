namespace nilnul.fs.git.depo.stow.document.checkout_
{
	/// <summary>
	/// during a conflicted merge, Git records the being-merged commit's ID in MERGE_HEAD, you can also git checkout MERGE_HEAD -- path/to/file to get the file from the other commit. This, too, extracts from a commit, so it writes to the index, resolving the file.
	/// </summary>
	interface IMergeHead { }

}
