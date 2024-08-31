using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches._merge
{
	/*
	 If you’re merging two branches, nilnul.win.prog_.Git uses a recursive strategy. If you’re merging more than two branches, nilnul.win.prog_.Git picks the octopus strategy. These strategies are automatically chosen for you because the recursive strategy can handle complex three-way merge situations — for example, more than one common ancestor — but it can only handle merging two branches. The octopus merge can handle multiple branches but is more cautious to avoid difficult conflicts, so it’s chosen as the default strategy if you’re trying to merge more than two branches.

However, there are other strategies you can choose as well. One of them is the subtree merge, and you can use it to deal with the subproject issue. Here you’ll see how to do the same rack embedding as in the last section, but using subtree merges instead.

		 */
	class Algo
	{
	}
}
