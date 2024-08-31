using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.bound_
{
	///mirrors.edge.kernel.org/pub/software/scm/git/docs/gitrevisions.html#_specifying_revisions
	/// <summary>
	/// In these two shorthand notations, you can omit one end and let it default to HEAD. For example, origin.. is a shorthand for origin..HEAD and asks "What did I do since I forked from the origin branch?" Similarly, ..origin is a shorthand for HEAD..origin and asks "What did the origin do since I forked from them?" Note that .. would mean HEAD..HEAD which is an empty range that is both reachable and unreachable from HEAD.
	/// </summary>
	internal class IDots
	{
	}
}
