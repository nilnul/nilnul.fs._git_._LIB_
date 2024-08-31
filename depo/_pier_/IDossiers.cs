namespace nilnul.fs.git.depo._pier_
{

	///git-scm.com/docs/index-format
	/// index entries are sorted;
	///Entries with the same name are sorted by their stage field.
	///the index may contain entries for directories outside of the sparse-checkout definition.
	///
	/// <summary>
	/// git ls-files --cached
	/// ,or,
	/// git ls-files -c
	/// or
	/// git ls-files
	///		, as "cached" is default when no other options are provided;
	/// </summary>
	/// <remarks>
	/// when the head_.branch is unborn, this returns empty;
	/// if one file is deleted, and the deletion is staged, then it's not shown here;
	/// if one file is deleted, and the deletion is not staged, then its shown here;
	///
	/// 
	/// hence this is purely the entries in cache|index, not including those in head but not in index.
	/// </remarks>
	/// 
	/// <see cref="dossiers.vw_.IMode"/>
	///

	/// 
	interface IDossiers :destinys_.ITracked {
	

	}
}
