namespace nilnul.fs.git.depo.repo
{
	/// <summary>
	/// a commit, which is node|version of the history;a snapshot of the repo at a particular point in time.
	/// </summary>
	/// <remarks>
	///A Git commit object contains all the metadata of the commit. This includes the date, author, committer, the commit message, as well as the directory tree object hash, and parent commit hash(es).
	/// </remarks>
	/// alias:
	///		revision, as in git manual;
	///		commit
	///		snapshot
	public interface ISnap {

		/*
	 Contains:
	 * The name (a hash) of the working directory’s snapshot
	 * A comment
	 * Commiter information
	 * Hash of the parent commit*/
	}
}
