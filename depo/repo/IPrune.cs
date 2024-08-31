namespace nilnul.fs.git.depo.repo
{
	/// <summary>
	/// gi prune
	/// </summary>
	/// <remarks>
	/// when there is garbage such as "pack/tmp_pack_2f2f1d", we would see "size-garbage: 1.2GiB" from "git count-objects -vH";
	/// git gc might not clear it but git prune would do;
	/// </remarks>
	interface IPrune { }
}
