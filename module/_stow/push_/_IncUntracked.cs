using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash.push_
{
	/*
	I wanted to stash untracked files, but I keep passing the wrong option.To me this sounds right:
git stash save[-a | --all]
but this in fact stashes ignored files as well.The correct one is:
git stash save[-u | --include - untracked]
*/

	class _IncUntrackedX
	{
	}
}
