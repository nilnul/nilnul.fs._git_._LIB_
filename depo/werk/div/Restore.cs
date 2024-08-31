using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div
{
	static public class _RestoreX
	{
		/*
	   git checkout HEAD -- <path>

			git checkout -- <path> doesn't do a hard reset: it replaces the working tree contents with the staged contents. 
git checkout HEAD -- <path> does a hard reset for a path, replacing both the index and the working tree with the version from the HEAD commit.
As answered by Ajedi32, both checkout forms don't remove files which were deleted in the target revision.
If you have extra files in the working tree which don't exist in HEAD, a git checkout HEAD -- <path> won't remove them.
Note: With git checkout --overlay HEAD -- <path> (Git 2.22, Q1 2019), files that appear in the index and working tree, but not in <tree-ish> are removed, to make them match <tree-ish> exactly. 
			*/

		/// <summary>
		/// restore the content of a div to the snap of HEAD
		/// </summary>
		/// <param name="div"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public void Vod(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DivI div
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				module,
				$"checkout -- { nilnul.fs._address.div.phrase_.QuoteIfNeed.Singleton.phrase( div)}"
				,git
			);
			
		}
		static public void Vod(
			nilnul.fs.folder_.git_.Work work
			
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				work.en
				,
				$"checkout -- ."		// "." means current directory.
				,git
			);
		}

		static public void Vod_exeInDiv(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DivI div
			,
			nilnul.win.prog_.Git git=null
		)
		{
			Vod(
				new nilnul.fs.folder_.git_.Work( new nilnul.fs.address_.shield_.BaseDiv(module.top1.en.address.en,div)
				)
				
				,
				git
			);
		}
		

	}
}
