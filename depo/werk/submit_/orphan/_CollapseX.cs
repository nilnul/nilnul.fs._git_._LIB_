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

namespace nilnul.fs.git.module.work.commit_.orphan
{



	/// <summary>
	/// if the last two bakBranches are same in contents, delete the latest one, 
	/// </summary>
	public static class _CollapseX
	{
		public static string _Branch_0moduleAddress_1stowBranch_2werkBranch(
			string _location
			,
			string _assumeStowBranch
			,
			string _assumeSkimKey	//="shelf"
			,
			out bool newlyCreated//=false
			,
			nilnul.os.prog_.Git git = null
		)
		{
			///create the bak branch; and also reset the head; soe here, the bak branch is not the default branch, and thus can be force dropped;
			///
			var branch = _Snap2orphanX._Branch_0moduleAddress_1stowBranch_2werkBranch(_location,_assumeStowBranch, _assumeSkimKey, git);

			var newBranch = module.repo.branch_.vered_.nub_.newest_.noncurrent.retract_._ToOrphanX._Regress_addressAssumeModule_branchAssumeNewest(_location, branch, git);
			newlyCreated = (branch == newBranch); // if branch is the new one;
			return newBranch;
		}
		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="_stowBranch">the stage and the werk</param>
		/// <param name="_werkKey">this is not the branch, but a stub for that branch</param>
		/// <param name="git"></param>
		/// <returns>the branch of the latest content.</returns>

		public static string _Branch_addressAssumeModule_assumeShelfNub(
			string _location
			,
			string _stowBranch
			,
			string _werkKey	//="werk"|"shelf"
			,
			out bool newlyCreated//=false
			,
			nilnul.os.prog_.Git git = null
		)
		{
			
			///create the bak branch; and also reset the head; soe here, the bak branch is not the default branch, and thus can be force dropped;
			///
			var branch = _Snap2orphanX._Branch_addressAssumeModule_assumeNub(_location,_stowBranch, _werkKey, git);

			var newBranch = module.repo.branch_.vered_.nub_.newest_.noncurrent.retract_._ToOrphanX._Regress_addressAssumeModule_branchAssumeNewest(_location, branch, git);
			newlyCreated = (branch == newBranch);//the branch is the new one, not an old one;
			return newBranch;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_module"></param>
		/// <param name="_stowBranch">the stage and the werk</param>
		/// <param name="_werkKey"></param>
		/// <param name="newlyCreated"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static string _Branch_assumeModule_assumeShelfNub(
			fs.FolderI _module
			,
			string _stowBranch
			,
			string _werkKey //="werk"
			,
			out bool newlyCreated
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return _Branch_addressAssumeModule_assumeShelfNub(
				_module.ToString()
				,
				_stowBranch
				, _werkKey,
				out newlyCreated,
				git
			);
		}
	}
}
