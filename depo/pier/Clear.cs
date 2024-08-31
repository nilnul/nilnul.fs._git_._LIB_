using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage
{
	public class _ClearX
	{
		/*

			First:
git rm -r --cached . 
git add .


Then:
git commit -am "Remove ignored files"


			 */

		/*
		 You can create a branch as an orphan:
git checkout --orphan <branchname>


This will create a new branch with no parents. Then, you can clear the working directory with: 
git rm --cached -r .


and add the documentation files, commit them and push them up to github.

A pull or fetch will always update the local information about all the remote branches. If you only want to pull/fetch the information for a single remote branch, you need to specify it.

			 */


		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// 
		[Obsolete("check that 'rm --cached only removes cache not work'",false)]
		static public void Clear(nilnul.win.prog_.Git git, nilnul.fs.Folder module) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(module, "rm --cached -r .",git);
			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(module, "rm --cached -r -f .");

			/*
			 -f --force 
Override the up-to-date check

			 */


			/*
 git rm --cached -r .

--cached tells it to remove the paths from staging and the index without removing the files themselves and -r operates on directories recursively. You can then git add any files that you want to keep tracking.

	 */
		}
		/*
 You can unstage files from the index using
git reset HEAD -- path/to/file


Just like git add, you can unstage files recursively by directory and so forth, so to unstage everything at once, run this from the root directory of your repository:
git reset HEAD -- .


Also, for future reference, the output of git status will tell you the commands you need to run to move files from one state to another.
*/
		static public void Clear( nilnul.fs.Folder module) {
			Clear(nilnul.win.prog_.Git.StaticInstance, module);
		}
	}
}

/*
 git rm will remove entries from the staging area. This is a bit different from git reset HEAD which "unstages" files. By "unstage" I mean it reverts the staging area to what was there before we started modifying things. git rm on the other hand just kicks the file off the stage entirely, so that it's not included in the next commit snapshot, thereby effectively deleting it.

By default, a git rm file will remove the file from the staging area entirely and also off your disk > (the working directory). To leave the file in the working directory, you can use git rm --cached.

	 */
