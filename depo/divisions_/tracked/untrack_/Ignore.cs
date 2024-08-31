using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.divisions_.tracked.untrack_
{
	/// <summary>
	/// first untrack, then ignore it:
	/// Using the --cached option with git rm means that the file will be deleted from your repository, but will remain in your working directory as an ignored file:
	///		$ echo debug.log >> .gitignore
	///		$ git rm --cached debug.log
	///		rm 'debug.log'
	///		$ git commit -m "Start ignoring debug.log"
	/// 
	/// </summary>
	internal class Ignore
	{
	}
}
