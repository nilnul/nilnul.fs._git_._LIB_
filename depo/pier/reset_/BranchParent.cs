using nilnul.fs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.reset_
{
	/// <summary>
	/// a work-tree under a tentative commit
	/// </summary>
	static public class _BranchParentX
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
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_location
				,
				"reset " + 
					_branch+"^"	//the parent of branch
				+ "--"	//seperator: before this is tree-ish, after this would be paths
				+ " ."		// all under this directory.
			);

		}

		//public static void _Set2HeadParent(Folder folderGit)
		//{

		//	_Set2HeadParent(folderGit.git, folderGit.location);

		//	//throw new NotImplementedException();
		//}

		//static public void _Set2HeadParent(nilnul.win.prog_.Git git, string _location)
		//{
		//	nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
		//		_location
		//		,
		//		"reset " + 
		//			"HEAD"+"^"	//the parent of branch
		//		+ " -- "	//seperator: before this is tree-ish, after this would be paths
		//		+ " ."		// all under this directory. //todo: will this be optional?
		//	);

		//}

		/*
		 git reset HEAD <file>..." to unstage
		 */

		/*
		 git ls-files --stage 
		 */


	}
}
