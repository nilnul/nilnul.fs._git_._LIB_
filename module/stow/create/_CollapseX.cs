using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs.address_.spear_.exist;

namespace nilnul.fs.git.module.stow.create
{



	/// <summary>
	/// if the last two bakBranches are same in contents, delete the last one, 
	/// </summary>
	public static class _CollapseX
	{
		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>the branch of the latest content.</returns>

		public static string _Branch_addressAssumeModule_assumeShelfNub(
			string _location
			,
			string _assumeShelfKey	//="shelf"
			,
			out bool newlyCreated//=false
			,
			nilnul.os.prog_.Git git = null
		)
		{
			///create the bak branch; and also reset the head; soe here, the bak branch is not the default branch, and thus can be force dropped;
			///
			var branch = _CreateX._Branch_addressAssumeModule_assumeNub(_location, _assumeShelfKey, git);

			var newBranch =module.repo.branch_.vered_.nub_.newest._RegressX._Regress_addressAssumeModule_branchAssumeNewest(_location, branch, git);
			newlyCreated = (branch == newBranch);
			return newBranch;
		}

		public static string _Branch_assumeModule_assumeShelfNub(
			fs.FolderI _module
			,
			string _assumeShelfKey
			,
			out bool newlyCreated
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return _Branch_addressAssumeModule_assumeShelfNub(_module.ToString(), _assumeShelfKey, out newlyCreated, git);
		}
	}
}
