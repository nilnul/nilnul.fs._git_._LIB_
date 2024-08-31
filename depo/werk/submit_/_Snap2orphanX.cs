using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.commit_
{
	/// not in batch;
	/// <summary>
	/// only the work, orphanated without stage;
	/// </summary>
	/// <remarks>
	/// create an orphanated branch; 	
	/// clear the stage; commit the work to that orphanated branch;
	/// We do so to clear history which might have large files that exceeds server limit, and split large files in work before pushing it to server;
	/// 
	/// no index is commited; in other words, index is reset;
	///
	/// 
	/// this can be used in nilnul.dev.bak;
	/// </remarks>
	/// alias:
	///		snatch
	///		scratch, from scratch
	///		skim
	///			
	public static class _Snap2orphanX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="_stowBranch"><see cref="IStow"/>:stage9work</param>
		/// <param name="_werkBranch"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		public static string _Branch_0moduleAddress_1stowBranch_2werkBranch(
			string _location
			, string _stowBranch
			,
			string _werkBranch  //branchName, not the prefix;	/// this would be the tip of the shelf
			,
			nilnul.os.prog_.Git git = null
		)
		{

			/// todo: utilizing stash to create the worksiet commit and bakbranch.
			/// per web, stash is not robust: it might remove some ignored directories to keep the werk clean;

			fs.git.Module module = nilnul.fs.git.Module.FroAddress(_location);




			/// to0do: consider using "git stash", which throws when there is no commits;
			string _oldHead = fs.git.module.repo.current._VwX.Txt(module, git);
			Trace.TraceInformation($"oldHead:{_oldHead} of {_location}");
			Trace.TraceInformation($"switching to branch {_werkBranch}  for {_location}");

			try
			{
				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
					_location,
					$"checkout --orphan {_werkBranch}" //don't use switch --orphan as it may fail due to:
					/*
					 error: Your local changes to the following files would be overwritten by checkout:
.gitignore
Please commit your changes or stash them before you switch branches.
Aborting
					 */
					// it seems that switch would try to reset stage and|or work, resulting loss of modification to workspace; it will complain about modified, not deleted;
					,
					git
				);
			}
			catch (Exception x)
			{

				throw new Exception($"exception {x} when: checkout --orphan {_werkBranch} @ {_location}", x);
			}

			//Trace.TraceInformation($"committing worksite for { _location}");

			try
			{

				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
					_location, $"reset", git
				); /// we presume that the <see cref=""/>
			}
			catch (Exception ex)
			{
				Trace.TraceError($" when resetting on the newly created orphan branch for {_location}:{ex}");
				Trace.TraceInformation($"setting head to original @ {_location}");
				fs.git.module.repo.current._AssignX._Assign_1assumeHead(module, _oldHead);
				Trace.TraceInformation($"setted head to original @ {_location}");
				throw;
			}

			Trace.TraceInformation($"adding and committing all changes at {_location}");

			try
			{

				new nilnul.obj.vow_.true_.xpn_.Unacceptable(
					$"exception when further adding all and commiting for {_location}"
				).vow(
					nilnul.fs.git.module.index.add_.all_.minWinTitled.commit_.allowEmpty_._MinWinTitledX.CommitExitCode_AddAndCommit(_location
					,
					$"backup work, excluding index, in an orphan branch;" // let's keep this message different from the one used in bak;
					,
					git
				) == 0
				); /// todo: we presume that every large file has been split;
			}
			catch (Exception e)
			{
				Trace.TraceError($" when commiting all for stashing for {_location}:{e}");

				Trace.TraceInformation($"setting head to original @ {_location}");

				fs.git.depo.repo.head.assign_.ref_._BranchX._Vod_1branch(module, _stowBranch);

				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(_location, "reset HEAD~", git);
				fs.git.module.repo.current._AssignX._Assign_1assumeHead(module, _oldHead);
				Trace.TraceInformation($"setted head to original   @ {_location}");
				throw;
			}
			Trace.TraceInformation($"added and committed all changes at {_location}");
			#region make a tmp branch such that we can step back with the tip therein without affecting others
			// move to the shelf branch in order to restore the work; and later take a step back to restore the index;
			fs.git.depo.repo.head.assign_.ref_._BranchX._Vod_1branch(module, _stowBranch);

			///create temp branch to backoff
			///

			var ver = nilnul.txt_.vered._VerX.Txt(_werkBranch);

			string tempBranch = $"_w"  //lest it will conflict with temp branch used previously and exist due to crash
				+
				ver;
			//nilnul.txt_._GuidX.Construct_noHyphen(Guid.NewGuid());

			Trace.TraceInformation($"creating temp branch:{tempBranch} @ {_location}");
			nilnul.os.prog_.git.run_.exit.cod.vow_.nil_._CustomXpnX.OfAddress(_location, $"checkout -b {tempBranch}", $"exception when checkout -b {tempBranch} @{_location}", git); // at stow
			Trace.TraceInformation($"created temp branch{tempBranch}  @ {_location}");
			#endregion
			try
			{

				Trace.TraceInformation($"backtracking head  @ {_location}");

				//change the index to the HEAD~; this restores index.
				//this also moved branch: the tmp one;
				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX.OfAddress(_location, "reset HEAD~", git); /// todo: we are moving back along shelfBranch, from the tip(stowSnap) to the worksite(indexBranch)

				Trace.TraceInformation($"backtracked  @ {_location}");

			}
			catch (Exception e)
			{
				throw new Exception(
					$"reset Head~ @{_location} where current branch is {tempBranch}, and {_stowBranch} as a shelf(like stash) shall have a commited index and a commited werk, but unexpected exception as the inner one happens;"
					,
					e
				);
			}

			Trace.TraceInformation($"setting head to original  @ {_location}");
			//// avoid the lock of files in .git such as head.lock or index.lock

			/// restore the old head.
			fs.git.module.repo.current._AssignX._Assign_1assumeHead(module, _oldHead);

			Trace.TraceInformation($"setted head to original  @ {_location}");
			Trace.TraceInformation($"removing tmp branch  @ {_location}");

			//// avoid the lock of files in .git such as head.lock or index.lock
			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);


			nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);
			Trace.TraceInformation($"removed tmp branch  @ {_location}");

			return _werkBranch;


		}

		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="_shelfBranch">
		/// after commit worksnap, we need to move to the shelf branch and then step back to get the index; then we get another step back to get the original (before shelf and snatch ) head.
		/// this will restore the head, the index, and the work.
		/// </param>
		/// <param name="git"></param>
		/// <param name="_werkKey">for bak, this is historically named "bak_snap"; the timestamp from <paramref name="_shelfBranch"/> is used to suffix this;</param>

		public static string _Branch_addressAssumeModule_assumeNub(
			string _location
			, string _shelfBranch
			,
			string _werkKey = PREFIX4BRANCH // "werk" //  werk; orphan , but doesnot mean it's work as it might be other orphan branch such as pub branch ? skim
			,
			nilnul.os.prog_.Git git = null
		)
		{



			var timestamp = nilnul.txt_.vered._VerX.Txt(_shelfBranch);


			//string timestamp = nilnul.time_.datetime.phrase_.Full.Singleton.phrase();

			return _Branch_0moduleAddress_1stowBranch_2werkBranch(_location, _shelfBranch, $"{_werkKey}{timestamp}", git);


		}

		public const string PREFIX4BRANCH = "werk";
		public static string _Branch_assumeModule_assumeNub(
			fs.FolderI _module
			,
			string _shelfBranch
						,
			string _orphanAssumeKey = PREFIX4BRANCH// "orphan"
,
			nilnul.os.prog_.Git git = null
		)
		{
			return _Branch_addressAssumeModule_assumeNub(_module.ToString(), _shelfBranch, _orphanAssumeKey, git);
		}




	}
}
