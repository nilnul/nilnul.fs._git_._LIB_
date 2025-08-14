using System;

namespace nilnul.fs.git.depo.repo.snap
{
	/*
 * If config parameter "core.logAllRefUpdates" is true and the ref is:

one under "refs/heads/", "refs/remotes/", "refs/notes/", or
a pseudoref like HEAD or ORIG_HEAD; or
the file "$GIT_DIR/logs/<ref>" exists
then git update-ref will append a line to the log file "$GIT_DIR/logs/<ref>" (dereferencing all symbolic refs before creating the log name) describing the change in ref value.*/

	/// https://mirrors.edge.kernel.org/pub/software/scm/git/docs/gitrevisions.html
	/// <summary>
	///  like <see cref="nilnul.obj.IExpr{nilnul.fs.git.depo.repo.snap}"/>; this can itself act like an operand.
	/// </summary>
	///
	[Obsolete(nameof(IExpr))]
	public interface IRepresentation:nilnul.obj.IExpr<repo.ISnap>
	{
	}

}
