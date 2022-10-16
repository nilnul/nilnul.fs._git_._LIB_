using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.repo._import
{
	public class Limit
	{
		/*

Push size

There's one exception where large pushes are normal. When you migrate a repository from another service into Azure Repos, it comes in as a single push. We don't intend to block imports, even of very large repositories. If the repository is more than 5GB, then you must use the Import repository feature instead of the command line.*/

		public static nilnul.num.ext_.Inf1 HardLimit = num.ext_.Inf1.Singleton;


	}
}
