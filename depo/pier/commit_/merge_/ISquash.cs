using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.commit_.merge_
{
	/// <summary>
	/// When making a squash merge, git merge deliberately does not write the extra parent ID to the extra file, so that the new merge commit has only a single parent. (For some reason, git merge --squash also suppresses the automatic commit, as if it included the --no-commit flag as well )
	/// </summary>
	internal class ISquash
	{
	}
}
