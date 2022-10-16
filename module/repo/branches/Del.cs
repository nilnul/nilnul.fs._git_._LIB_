using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches
{
	static public class _DelX
	{
		static public void Del(
			nilnul.fs.git.ModuleI top
			,
			IEnumerable<_branch.Name> branches
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.objs._EachX.Each(
				branches
				,
				x => repo.branch._DropX.Drop(top,x,git)
			
			);
		}

		static public void Del(
			nilnul.fs.folder_.git_.Top top
			,
			IEnumerable<_branch.Name> branches
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.objs._EachX.Each(
				branches
				,
				x => repo.branch._DropX.Drop(top,x,git)
			
			);
		}


		static public void Del(
			nilnul.fs.folder_.git_.Top top
			,
			IEnumerable<string> branches
			,
			nilnul.win.prog_.Git git=null
		) {
			Del(top, branches.Select(x=> new _branch.Name(x)),git);
		}


		/*
		 $ git branch -d <branch_name>
		 */

		/*
If there are unmerged changes which you are confident of deleting:
$ git branch -D <branch_name>
		 */
	}
}
