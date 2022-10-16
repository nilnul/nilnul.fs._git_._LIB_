using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.repo._pushed
{
	public class Limit
	{
		public const int Gb = 5;
		/*

Push size
Very large pushes use up a lot of resources, blocking or slowing other parts of the service. Such pushes often don't map to normal software development activities. Someone may have inadvertently checked in build outputs or a VM image, for example. For these reasons and more, pushes are limited to 5GB at a time.

There's one exception where large pushes are normal. When you migrate a repository from another service into Azure Repos, it comes in as a single push. We don't intend to block imports, even of very large repositories. If the repository is more than 5GB, then you must use the Import repository feature instead of the command line.*/

	}
}
