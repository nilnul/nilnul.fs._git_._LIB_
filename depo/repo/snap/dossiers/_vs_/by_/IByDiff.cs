namespace nilnul.fs.git.depo.repo.snap.dossiers._vs_.by_
{
	///https://superuser.com/a/1077960
	///
	/// <summary>
	/// git diff --diff-filter=[D|M|A] branch1 branch2
	///		,where D: sort files existing in branch1 only.
	///		M: sort files have been modified
	///		A: sort files existing in branch2 only.
	///		You can use all of them at the same time, also with "--stat" flag for a quick view of the changes.
	/// </summary>
	/// <remarks>
	///--name-only
	///	,can be added
	/// </remarks>
	interface IByDiff {

	}
}
