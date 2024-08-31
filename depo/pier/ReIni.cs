using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage
{
	/// <summary>
///	Your index is corrupt when you see this error running usual git commands like git pull, git status, etc.:
///error: bad index file sha1 signature
///fatal: index file corrupt
///Though it sounds bad, your changes are still there.Fix it by first removing the index file, then resetting the branch:
///rm .git/index
///git reset
///You should be all good now.
///To be safe, make a backup of .git/index before you delete it.
	/// </summary>
	public class ReIni
	{


	}
}
