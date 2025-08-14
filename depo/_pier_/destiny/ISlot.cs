namespace nilnul.fs.git.depo._pier_.destiny
{
	/// <summary>
	/// Each index slot contains, not the actual file contents, but rather the hash IDs of blob objects in the repository.
	/// </summary>
	/// <remarks>
	///ask Git to retrieve :n:path and it finds the blob ID in the index entry for path for slot n.
	///This colon-and-number syntax works everywhere in Git, while the --ours and --theirs flags only work in git checkout.
	/// </remarks>
	interface ISlot { }

}
