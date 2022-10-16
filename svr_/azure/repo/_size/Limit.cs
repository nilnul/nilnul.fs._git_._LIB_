using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.repo._size
{
	public class Limit
	{
		public const int BetterGb = 10;
		/*Repositories should generally be no larger than 10GB. You can run git count-objects -vH in a command prompt, and look for the entry called "size-pack" to determine how large your repository is:


Copy
D:\my-repo>git count-objects -vH

count: 482
size: 551.67 KiB
in-pack: 100365
packs: 25
size-pack: 642.76 MiB   <-- size of repository
prune-packable: 83
garbage: 0
size-garbage: 0 bytes
In uncommon circumstances, repositories may be larger than 10GB. For instance, the Windows repository is at least 300GB. For that reason, we do not have a hard block in place. If your repository grows beyond 10GB, consider using nilnul.win.prog_.Git-LFS, GVFS, or Azure Artifacts to refactor your development artifacts.

*/

		public static nilnul.num.ext_.Inf1 HardLimit =  num.ext_.Inf1.Singleton;
	}
}
