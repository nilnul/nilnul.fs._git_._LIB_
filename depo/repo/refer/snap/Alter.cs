using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.refer.snap
{
	/*There is a more direct way to force foo to c70611 without checking it out to be the current branch. Namely, you can rewrite what foo points to using the git update-ref command.*/

	/// <summary>
	///git update-ref refs/heads/master <newvalue> <oldvalue>
	///You can specify 40 "0" or an empty string as <oldvalue> to make sure that the ref you are creating does not exist.
	/// </summary>
	class Alter
	{
	}
}
