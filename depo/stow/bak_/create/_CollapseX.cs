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
	/// if the last two bakBranches are same in contents, and if the second latest is not orphan, delete the last one, 
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
			///create the bak branch; and also reset the head to old branch; so here, the bak branch is not the default branch, and thus can be forcefully dropped;
			///
			var branch = _CreateX._Branch_addressAssumeModule_assumeNub(_location, _assumeShelfKey, git);

			var newBranch =depo.repo.branch_.vered_.nob_.newest_.noncurrent.retract_._ToNonOrphanX._Regress_0moduleAddress_1branchNewestNoncurrent(_location, branch, git);
			newlyCreated = (branch == newBranch); // if the branch is new one, not the regressed one;
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
