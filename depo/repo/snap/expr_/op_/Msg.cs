using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.expr_.op_
{
	/// <summary>
	/// :/<text>, e.g. :/fix nasty bug
	/// ;A colon, followed by a slash, followed by a text, names a commit whose commit message matches the specified regular expression. returns the youngest matching commit which is reachable from any ref, including HEAD
	///  To match messages starting with a string, one can use e.g. :/^foo
	///  /!-foo performs a negative match
	///  /!!foo matches a literal ! character, followed by foo
	/// </summary>
	internal class ByMsg
	{
	}
}
