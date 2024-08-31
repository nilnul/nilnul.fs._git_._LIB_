using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.pseudo_
{
	/// <summary>
	/// eg:
	///		git update-ref master master
	///			,will create a file in .git/  as:   .git/master
	///		
	/// </summary>
	/// <remarks>
	/// once it's established, "warning: refname 'master' is ambiguous." will pop out if you use the shorthand for "master" in cmd;
	/// </remarks>
	internal class Custom
	{
	}
}
