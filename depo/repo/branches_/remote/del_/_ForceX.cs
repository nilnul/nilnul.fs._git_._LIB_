using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.remote.del_
{
	static public class _ForceX
	{
		static public void _Del(
			nilnul.fs.git.ModuleI top
			,
			IEnumerable<string> _branches
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.objs._EachX.Each(
				_branches
				,
				x => repo.branch_.remote.drop_._ForceX._Drop(top,x,git)
			
			);
		}

		static public void _Del(
			string top
			,
			IEnumerable<string> _branches
			,
			nilnul.win.prog_.Git git=null
		) {
			_Del(nilnul.fs.git.Module.FroAddress(top),_branches,git);
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
