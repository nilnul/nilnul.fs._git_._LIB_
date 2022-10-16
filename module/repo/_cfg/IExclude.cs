using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg
{
	/// <summary>
	/// divisions (paths) to ignore.
	/// putting ignore pattern here rather in workspace such that the pattern would be pushed to remote visible to public. The patterns are kept private/personal rather for a team.
	/// </summary>
	public interface IExclude
	{
	}
}
