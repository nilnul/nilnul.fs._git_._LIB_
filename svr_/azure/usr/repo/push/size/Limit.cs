using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client.repo.push.size
{
	/// <summary>
	/// single push cannot exceed 5GB.
	/// total cannot exceed 5GB.
	/// </summary>
	static public class _LimitX
	{
		public const int PUSH_IN_GIGABYTES = 5;
	}
}
