namespace nilnul.fs.git.depo
{
	/// <summary>
	/// replace the index entry for each file with the entry that goes with the other branch
	///If the contents are different
	///		, if git checkout is going to modify or remove the index entry, it also needs to modify or remove the work-tree file. Git makes sure this is a safe thing to do, i.e., that the work-tree file matches the current commit's file, before it will let you switch branches.
	///
	/// Note that all this action has used slot zero. There are no slot 1-3 entries at all, so that git checkout does not have to remove any such things.
	/// </summary>
	/// <remarks>
	/// the content of the head might changed.
	/// </remarks>

	interface ICheckout {


	}
}
