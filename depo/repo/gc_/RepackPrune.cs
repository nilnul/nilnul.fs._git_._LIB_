using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.gc_
{
	/// <summary>
	/// this works as per our test
	/// </summary>
	static public class _RepackPruneX
	{
		/*
		 


As I mentioned in "Git Garbage collection doesn't seem to fully work", a git gc --aggressive is neither sufficient or even enough on its own.

The most effective combination would be adding git repack, but also git prune:

git gc
git repack -Ad      # kills in-pack garbage
git prune           # kills loose garbage
*/
		static public string Report(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git=null)
		{
			return nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.ofParams(
			nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module, "gc", git)
			,
			nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module, "repack -Ad", git)
			,

			nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module, "prune", git)

			);

		}
	}
}
