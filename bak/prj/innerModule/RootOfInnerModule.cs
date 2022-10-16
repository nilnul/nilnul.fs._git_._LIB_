using nilnul.dev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.bak.prj.innerModule
{
	/// <summary>
	/// 
	/// </summary>
	public class RootOfInnerModule
	{
		/// <summary>
		/// Note: the remote is configured in git config.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="io"></param>
		/// <param name="err"></param>

		public static void _Proc(nilnul.win.prog_.Git git, string _location, Io io, ref bool paused, bak.Cfg cfg)
		{


			try
			{
				foreach (var dir in Directory.GetDirectories(_location))
				{
					root.Dir._Proc(git, dir, io, ref paused, cfg);
				}

				_SyncThis(git, _location, io, ref paused, cfg);

			}
			catch (Exception e)
			{

				io.err.writeRec($"prj.innerModule.Root._Proc(location:{_location}):");

				io.err.writer.WriteLine( e.Message);
			}
		}

		private static void _SyncThis(nilnul.win.prog_.Git git, string _location, Io io, ref bool paused, bak.Cfg cfg)
		{
			//io.err.writeRec($"begining processing {_location} as rootOfInnerModule");
			try
			{
				if (io.log.isDoneOnAllBranch(_location))
				{
					//io.err.writeRec($"all branches are already done for { _location}");

					return;
				}
				var folderGit = new nilnul.fs.git.Folder(git, _location);

				_BakBranchProc(git, _location, io, ref paused, cfg);
				_PushAllBranches(git, _location, io, ref paused, cfg);

			}
			catch (Exception e)
			{
				io.err.writeRec($"prj.innerModule.root.Sync(location:{_location}): \n\r" + e.Message);
			}
		}

		private static IEnumerable<string> _GetRemotes(nilnul.win.prog_.Git git, string _location, Cfg cfg)
		{

			var remotes = nilnul.fs.git.module.Remotes.GetRemotes_throws(
				git, _location

).Where(x => x.StartsWith(cfg.remotePrefix));


			var remotesGroupedByPrefix =
				from r
					in remotes
				group r by nilnul.txt.Versioned1.Parse( r).prefix into g
				select nilnul.txt.versioned.set_.Seeded.GetLatest(g);

			return remotesGroupedByPrefix;


		}


		private static void _BakBranchProc(nilnul.win.prog_.Git git, string _location, Io io, ref bool paused, bak.Cfg cfg)
		{

			if (paused)
			{
				//io.err.writeRec($"paused before bakBranch processing { _location}");

				return;
			}

			try
			{

				var folderGit = new nilnul.fs.git.Folder(git, _location);

				var bakBranch = cfg.branchPrefix +

					nilnul.time.to.Txt.ToTxtFull();


				//io.err.writeRec($"switching to branch {bakBranch}  for { _location}");

				var branchStacked = nilnul.fs.git.module.head.StackOne.Put(
					folderGit,
					bakBranch

				);



				//io.msg.writeRec($"committing worksite for { _location}");
				//io.err.writeRec($"committing worksite for { _location}");

				nilnul.fs.git.module.Branch._Commit_allowEmpty(folderGit, "commit workspace index for possibly restoring work site later");

				//todo : here we need a tag; reason: if we're in a detached head, and the user branch starts from somewhere else, we will not be able to tell where is our automatic commit start;  ------- no, we can always tell for we have always two commit; and they are described friendly.


				io.msg.writeRec($"add and committing { _location}");
				//io.err.writeRec($"add and committing all changes at { _location}");

				nilnul.fs.git.module.Branch.AddAll_n_Commit(folderGit, "add and commit all for backup");


				//io.err.writeRec($"to revert to worksite commited at { _location}");

				nilnul.fs.git.module.Stage._Set2HeadParent(folderGit);


				//io.err.writeRec($"to switch back to original branch at { _location}");

				branchStacked.pop();

				#region pushup the bakBranch.







				//io.msg.writeRec($"pushing {bakBranch} for { _location}");
				//io.err.writeRec($"pushing {bakBranch} for { _location}");
				_Push(git, _location, bakBranch, io, ref paused, cfg);


				#endregion
			}
			catch (Exception e)
			{
				io.err.writeRec($"prj.innerModule.Root.BakBranchProc(location:{_location}): \n\r" + e.Message);
			}
		}
		private static void _PushAllBranches(nilnul.win.prog_.Git git, string _location, Io io, ref bool paused, Cfg cfg)
		{
			foreach (var remote in _GetRemotes(git, _location, cfg))
			{

				_PushAllBranches(git, _location, remote, io, ref paused);

			}



		}
	private static void _Push(nilnul.win.prog_.Git git, string _location, string branch, Io io, ref bool paused, Cfg cfg)
		{
			foreach (var remote in _GetRemotes(git, _location, cfg))
			{

				_Push(git, _location,branch, remote, io, ref paused);

			}



		}
		private static void _PushAllBranches(nilnul.win.prog_.Git git, string _location, string remote, Io io, ref bool paused)
		{

			if (paused)
			{
				//io.err.writeRec($"paused before pusing all branches of {_location} to  {remote}");
				return;
			}

			io.msg.writeRec($"pusing { _location} to {remote}");
			//io.err.writeRec($"pusing all branches of {_location} to { remote}");

			try
			{
				nilnul.fs.git.module.repo.remote.Push.PushAllBranches(
									git, _location, remote
								);
				io.log.append(
					_location
					,
					""
					,
					nilnul.fs.git.bak._io._log._rec.Action.Push
					,
					 remote
			);


			}
			catch (Exception e)
			{
				io.err.writeRec($"prj.innerModule.Root.PushAllBranches(location: {_location} ,remote: {remote}):\n\r" + e.Message);

			}


		}

		private static void _Push(nilnul.win.prog_.Git git, string _location, string branch, string remote, Io io, ref bool paused)
		{

			if (paused)
			{
				//io.err.writeRec($"paused before pusing branch {branch} of {_location} to  {remote}");
				return;
			}

			io.msg.writeRec($"pusing {branch} from { _location} to {remote}");
			//io.err.writeRec($"pusing branch {branch} from {_location} to { remote}");

			try
			{


				nilnul.fs.git.module.repo.remote.Push.RemoteBranch(git, _location, remote, branch);
				/// to do : keep the record.
				///
				io.log.append(
					_location
					,
					branch
					,
					nilnul.fs.git.bak._io._log._rec.Action.Push
					,
					remote
				);


			}
			catch (Exception e)
			{
				io.err.writeRec($"prj.innerModule.Root.Push( branch:{branch},remote:{remote}, folder:{_location} ):{Environment.NewLine}" + e.Message);

				//throw;
			}




		}


	}
}
