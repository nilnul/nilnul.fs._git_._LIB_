using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._cfg._setting
{
	/// stackoverflow.com/questions/17683458/how-do-i-commit-case-sensitive-only-filename-changes-in-git
	///
	/// <summary>
	/// git config core.ignorecase false
	/// </summary>
	/// <remarks>
	///a bad idea to set this to false on an insensitive filesystem:
	///		,its just that filename lookup is ignoring the case;
	///		,Use git mv to move the file and see how git manages it. 
	/// </remarks>
	internal class IgnoreCase
	{
	}
}
