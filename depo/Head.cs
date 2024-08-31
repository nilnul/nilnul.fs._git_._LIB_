using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module
{
	public class Head1
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
		static public  void MoveBack( string folder, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(folder, "reset HEAD~ --soft",git);

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
		static public void Set2Branch( nilnul.fs.folder_.git_.Top module, nilnul.fs.git.module.repo._branch.Name _branch_new, nilnul.win.prog_.Git git=null)
		{
			win.prog_.git.run.exitCode.vow_._NilX.Void(module, "symbolic-ref HEAD " + "refs/heads/" + _branch_new);

		}

		public static void Set2Branch(nilnul.fs.Folder folder, string branch,  nilnul.win.prog_.Git git = null)
		{

			Set2Branch(new nilnul.fs.folder_.git_.Top(folder), new repo._branch.Name( branch), git);

		}
		static public void Set2Branch( string module, string _branch_new, nilnul.win.prog_.Git git=null)
		{
			Set2Branch( fs.folder_.git_.Top.FroAddress( module),new repo._branch.Name( _branch_new),git);

		}



		static public void Set2Ref( nilnul.fs.folder_.git_.Top module, git.repo._reference.Name _ref, nilnul.win.prog_.Git git = null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(module, "symbolic-ref HEAD " +  _ref);

		}



		static public void Set2Ref( string module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Set2Ref( fs.folder_.git_.Top.FroAddress( module), new git.repo._reference.Name(  _ref),git);

		}

		static public void _Checkout2NewBranch(nilnul.fs.folder_.git_.Top module, repo._branch.Name _branch_new, nilnul.win.prog_.Git git = null)
		
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(module, "checkout -b " + _branch_new);
		}


		static public void _Checkout2NewBranch(string module, string _branch_new, nilnul.win.prog_.Git git = null)
		{
			_Checkout2NewBranch( fs.folder_.git_.Top.FroAddress(module), new repo._branch.Name(_branch_new));
		}



		/// <summary>
		/// the content of the file HEAD; such as "refs/head/master" if the content of the file is "ref:refs/head/master"
		/// </summary>
		/// <param name="args"></param>
		/// 
		///git checkout -b my_new_branch 
		///Checking out the new branch will not discard your changes.








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
