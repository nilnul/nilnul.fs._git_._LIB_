using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr.repo._push
{
	internal class Limit
	{
		/// <summary>
		/// it seems the push would be successful if it's under 500M, but would be problematic if it's over 500M;
		/// </summary>
		public const int RECOMMENDED_IN_MEGABYTES = 500;

	}
}
