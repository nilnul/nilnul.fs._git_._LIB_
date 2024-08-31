using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.act_
{
	/*
	If you’ve messed up the working tree, but haven’t yet committed your mistake, you can return the entire working tree to the last committed state with

$ git reset --hard HEADIf you make a commit that you later wish you hadn’t, there are two fundamentally different ways to fix the problem:

You can create a new commit that undoes whatever was done by the old commit. This is the correct thing if your mistake has already been made public. 
You can go back and modify the old commit. You should never do this if you have already made the history public; nilnul.win.prog_.Git does not normally expect the "history" of a project to change, and cannot correctly perform repeated merges from a branch that has had its history changed. 

		 */
	public class Reset
	{
		/// <summary>
		/// 1.Make your current branch (typically master ) back to point at {SOME-COMMIT}
		///2.Then make the files in your working tree and the index("staging area") the same as the versions committed in {SOME-COMMIT} .
		/// </summary>
		static public void Back2Commit() {

		}
	}
}
