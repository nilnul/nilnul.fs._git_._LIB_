using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.branch_
{
	/// <summary>
	/// in "nilnul.dev.src.bak", we intend to treat the default branch, generally "master", sometimes "main", as the branch for backup everything, as we are working on it by default, and treat it as the backup of what is going on such as to make things simple and natural.
	///		to mitigate the intrusion by the backup into someone's development work at the default branch,
	///			1) the backup commit shall be with the message "bak"
	///			2) when in automation backup service, we may use a "bak" branch instead, leaving the use of default branch as the bak branch for manual backup only.
	///			3) developer shall avoid using master branch as a development branch. Rather, use the default branch as a working branch, to be backuped from time to time automatically. It's regarded as a workspace cache.
	/// </summary>
	class Bak
	{
	}
}
