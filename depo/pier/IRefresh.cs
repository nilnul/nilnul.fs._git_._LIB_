namespace nilnul.fs.git.depo.pier
{
	///stackoverflow.com/questions/2657935/checking-for-a-dirty-index-or-untracked-files-with-git
	///
	///  git update-index (git-add for a more user-friendly way to do some of the most common operations on the index): 
	/// Modifies the index. Each file mentioned is updated into the index and any unmerged or needs updating state is cleared.
	/// the assume-unchanged bit is honored;
	/// <summary>
	///You may need to do
	/// git update-index -q --refresh
	/// before the diff-index to avoid some “false positives” caused by mismatching stat(2) information.
	/// </summary>
	/// <remarks>
	/// --refresh does not calculate a new sha1 file or bring the index up to date for mode/content changes. But what it does do is to "re-match" the stat information of a file with the index, so that you can refresh the index for a file that hasn’t been changed but where the stat entry is out of date (eg, when you restore a change within the werk;).
	/// </remarks>
	/// 
	/// vs:
	///		<see cref="refresh_.IReally"/>
	interface IRefresh { }
}
