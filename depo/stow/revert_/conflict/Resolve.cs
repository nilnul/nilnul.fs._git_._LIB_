using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.revert_.conflict
{
	internal class Resolve
	{
		/*
		 when:
		 both modified:   new.txt
		,

Since there is conflict for new.txt when reverting, you should modify the new.txt and finish the revert:

# modify and save the new.txt
git add .
git revert --continue
		 */

		/// <see cref="depo.pier.destinys.revise_.PerWerk"/>
		/// when we resolved only the conflicts in the both modified file,
		/// git add -A
		/// git revert --continue
	}
}
