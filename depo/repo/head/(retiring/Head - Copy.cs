using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	[Obsolete()]
	public class Head
	{
		/*
		 git branch -f branch-name new-tip-commit
		 */

		/*
		 * git checkout A
		git reset --hard 6
		*/


		/*
		 * 
		 * git reset HEAD~ --soft
*/
		static public  void MoveBack(nilnul.win.prog_.Git git, string folder)
		{
			git.runCmd_throwErr(folder, "reset HEAD~ --soft");

		}
		/*
		 * Yes, you can do this.
		git symbolic-ref HEAD refs/heads/otherbranch


		If you need to commit on this branch, you'll want to reset the index too otherwise you'll end up committing something based on the last checked out branch.

		git reset

		*/

		/*•Change HEAD to point to a branch that does exist:
git symbolic-ref HEAD refs/heads/some_other_branch

*/
		static public void Set2Branch(nilnul.win.prog_.Git git, string module, string _branch_new)
		{
			git.runCmd_throwErr(module, "symbolic-ref HEAD " + "refs/heads/" + _branch_new);

		}

		static public void Set2Ref(nilnul.win.prog_.Git git, string module, string _ref)
		{
			git.runCmd_throwErr(module, "symbolic-ref HEAD " +  _ref);

		}

		public static void Set2Branch(Folder folderGit, string v)
		{
			Set2Branch(folderGit.git, folderGit.address.ToString(), v);

		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		/// 
		///git checkout -b my_new_branch 
		///Checking out the new branch will not discard your changes.


		static public void _Checkout2NewBranch(nilnul.win.prog_.Git git, string module,string _branch_new)
		{
			git.runCmd_throwErr(  module, "checkout -b "+_branch_new);

			

		}

		static public void _AddAll(nilnul.win.prog_.Git git,string workingDir)
		{

			git.runCmd_throwErr(workingDir, "add --all");

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		///git symbolic-ref HEAD 
		///
		///<returns>returns refs/heads/your-branch</returns>
		static public  string GetHeadContent(nilnul.win.prog_.Git git, string module)
		{
			///return 
			return git.runCmd__retResult_throwErr(module, "symbolic-ref HEAD").Trim();

		}



		/*
		 

This answer is a bit longer than that of Charles, but it consists solely of basic git commands that I can understand and thus remember, eliminating the need to keep looking it up.

Mark your current location (commit first if needed):
git checkout -b temp


Reset (moves) the marker to the other branch without changing working dir:
git reset <branch where you want to go>


now temp and other branch point to the same commit, and your working dir is untouched.
git checkout <branch where you want to go>


since your HEAD is already pointing to the same commit, working dir is not touched
git branch -d temp


Note that these commands are also readily available from any graphical client.


shareimprove this answer
 

edited Jul 14 at 22:23 


answered Jul 1 '12 at 2:08 

 
I would prefer git reset --soft <branch where you want to go> to avoid updating the index – JoelFan Nov 23 '15 at 15:29  
 
*/


		/*
		 * 
		 * git symbolic-ref HEAD refs/heads/branch
		 * */
		/*
		git rev-parse --abbrev-ref HEAD 
		*/

		/*
		 		 git ls-files --stage 

		 */

		/*
		 git rev-parse HEAD
		 */
	}
}
