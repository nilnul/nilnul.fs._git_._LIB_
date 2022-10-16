using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// a work-tree under a tentative commit
	/// </summary>
	public class Stage
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		/// <remarks>
		///  
		/// </remarks>
		static public void _Set2BranchParent(nilnul.win.prog_.Git git, string _location,string _branch)
		{
			git.runCmd_throwErr(
				_location
				,
				"reset " + 
					_branch+"^"	//the parent of branch
				+ "--"	//seperator: before this is tree-ish, after this would be paths
				+ " ."		// all under this directory.
			);

		}

		public static void _Set2HeadParent(Folder folderGit)
		{

			_Set2HeadParent(folderGit.git, folderGit.address.ToString());

			//throw new NotImplementedException();
		}

		static public void _Set2HeadParent(nilnul.win.prog_.Git git, string _location)
		{
			git.runCmd_throwErr(
				_location
				,
				"reset " + 
					"HEAD"+"^"	//the parent of branch
				+ " -- "	//seperator: before this is tree-ish, after this would be paths
				+ " ."		// all under this directory. //todo: will this be optional?
			);

		}

		/*
		 git reset HEAD <file>..." to unstage
		 */

		/*
		 git ls-files --stage 
		 */


	}
}
