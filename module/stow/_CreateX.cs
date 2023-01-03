using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stow
{
	/// <summary>
	/// create a branch (stage and incrementalChange8Work) on top of current commit(if any)
	/// simulate git stash; we don't use git Stash as it errors if what to stash is empty.
	/// </summary>
	public static class _CreateX
	{
		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static string _Branch_addressAssumeModule_assumeNub(
			string _location
			,
			string _shelfAssumeKey="shelf"
			,
			nilnul.os.prog_.Git git = null
		)
		{

			/// todo: utilizing stash to create the worksiet commit and bakbranch.

			fs.git.Module module = nilnul.fs.git.Module.FroAddress(_location);


			string timestamp = nilnul.time_.datetime.phrase_.Full.Singleton.phrase();

			/// this would be the tip of the shelf
	
			string bakBranch = _shelfAssumeKey + timestamp;

			/// to0do: consider using "git stash", which throws when there is no commits;
			string _oldHead = fs.git.module.repo.head._VwX.Txt(module, git);
			Trace.TraceInformation($"oldHead:{_oldHead} of {_location}");
			Trace.TraceInformation($"switching to branch {bakBranch}  for { _location}");

			try
			{
				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
					_location, $"checkout -b {bakBranch}", git
				);       
			}
			catch (Exception x)
			{

				throw new Exception($"exception {x} when: checkout -b {bakBranch} @ {_location}", x);
			}

			Trace.TraceInformation($"committing worksite for { _location}");

			try
			{
				
				int exitCode = nilnul.fs.git.module.index.commit_.allowEmpty_._MinUiTitledX.ExitCode(
					_location
					,
					"commit workspace index for possibly restoring work site later"
					,
					git
				);

				new nilnul.obj.vow_.true_.xpn_.Unacceptable($"exception (exitCode:{exitCode}) When commiting worksite index/stage for {_location}: the exception is shown on the popped console, repeat the operation in git bash to repro").vow(
					exitCode
					==
					0
				);

			}
			catch (Exception ex)
			{
				Trace.TraceError($" when commiting worksite for {_location}:{ex}");
				Trace.TraceInformation($"setting head to original @ {_location}");

			
				fs.git.module.repo.current._AssignX._Assign_1assumeHead(module, _oldHead);
				Trace.TraceInformation($"setted head to original @ {_location}");

				throw;
			}


			Trace.TraceInformation($"adding and committing all changes at { _location}");

			try
			{
				new nilnul.obj.vow_.true_.xpn_.Unacceptable(
					$"exception when further adding all and commiting for {_location}"
				).vow(
					nilnul.fs.git.module.index.add_.all_.minWinTitled.commit_.allowEmpty_._MinWinTitledX.CommitExitCode_AddAndCommit(_location,  $"add and commit all for backup", git) == 0
				);
			}
			catch (Exception e)
			{
				Trace.TraceError($" when commiting all for stashing for {_location}:{e}");

				Trace.TraceInformation($"setting head to original @ {_location}");

				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(_location, "reset", git);
				fs.git.module.repo.current._AssignX._Assign_1assumeHead(module, _oldHead);

				Trace.TraceInformation($"setted head to original   @ {_location}");
				throw;
			}

			Trace.TraceInformation($"added and committed all changes at { _location}");
			#region make a tmp branch such that we can step back with the tip therein without affecting others

			///create temp branch to backoff
			///
			string tempBranch = "_"
				+
				timestamp;
			//nilnul.txt_._GuidX.Construct_noHyphen(Guid.NewGuid());

			Trace.TraceInformation($"creating temp branch:{tempBranch} @ {_location}");




			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"checkout -b {tempBranch}", $"exception when checkout -b {tempBranch} @{_location}", git);

			Trace.TraceInformation($"created temp branch{tempBranch}  @ {_location}");
			#endregion
			Trace.TraceInformation($"backtracking head  @ {_location}");


			//change the index to the HEAD~; also moved branch
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX.OfAddress(_location, "reset HEAD~", git);

			Trace.TraceInformation($"backtracked  @ {_location}");

			Trace.TraceInformation($"setting head to original  @ {_location}");

			//// avoid the lock of files in .git such as head.lock or index.lock

			
			fs.git.module.repo.current._AssignX._Assign_1assumeHead(module, _oldHead);

			Trace.TraceInformation($"setted head to original  @ {_location}");
			Trace.TraceInformation($"removing tmp branch  @ {_location}");

			//// avoid the lock of files in .git such as head.lock or index.lock
			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);

			
			nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);
			Trace.TraceInformation($"removed tmp branch  @ {_location}");



			return bakBranch;


		}


		public static string _Branch_assumeModule_assumeNub(
			fs.FolderI _module
						,
			string _shelfAssumeKey="shelf"
,
			nilnul.os.prog_.Git git = null
		)
		{
			return _Branch_addressAssumeModule_assumeNub(_module.ToString(),_shelfAssumeKey, git);
		}




	}
}
