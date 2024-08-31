using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo.remote.push_.branch
{
	static public class _TaskX
	{
		static public  Task<int> Exe(
			nilnul.fs.git.Module workingDir, 
			_cfg_._remote.Name remote
			,
			nilnul.fs.git.module.repo._branch.Name branch
			, 
			CancellationToken cancel, 
			nilnul.win.prog_.Git git = null)
		{
			return Task.Run( ()=>_BranchX.ExitCode(workingDir,remote,branch,git),cancel); 
		}

		static public  Task<int> Exe(
			nilnul.fs.git.Module workingDir
			, _cfg_._remote.Name remote
			,
			nilnul.fs.git.module.repo._branch.Name branch

			, nilnul.win.prog_.Git git = null)
		{
			return Task.Run( ()=>_BranchX.ExitCode(workingDir,remote,branch,git)); 
		}




		static public Task<int> Exe(
			nilnul.fs.git.Module workingDir, 
			string remote,
			string branch, 
			nilnul.win.prog_.Git git = null)
		{
			return Exe(
				workingDir
				, new _cfg_._remote.Name(remote)
				,new _branch.Name( branch)
				, git
			);
		}

		static public Task<int> Exe(
			nilnul.fs.git.Module workingDir, 
			string remote
			, string branch
			, 
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null)
		{
			return Exe(
				workingDir
				, new _cfg_._remote.Name(remote)
				,new _branch.Name( branch)
				, cancel
				,git
			);
		}



		static public Task<int> Exe(string workingDir, string remote, string branch, nilnul.win.prog_.Git git = null)
		{
			return Exe(fs.git.Module.FroAddress(workingDir), new _cfg_._remote.Name(remote),branch, git);
		}


		static public Task<int> Exe(string workingDir, string remote, string branch, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			return Exe(fs.git.Module.FroAddress(workingDir), new _cfg_._remote.Name(remote),branch,cancel, git);
		}

		static public Task<int> Exe(nilnul.fs.folder_.git_.Top workingDir, _cfg_._remote.Name remote
						,
			nilnul.fs.git.module.repo._branch.Name branch
, G git = null)
		{
			return Exe(new Module(workingDir), remote, branch ,git);

		}

		static public Task<int> Exe(nilnul.fs.folder_.git_.Top workingDir, _cfg_._remote.Name remote
						,
			nilnul.fs.git.module.repo._branch.Name branch
, CancellationToken cancel, G git = null)
		{
			return Exe(new Module(workingDir), remote, branch,cancel, git);

		}

		static public Task<int> Exe(
			nilnul.fs.FolderI workingDir, 
			string remote
			, string branch
			,
			G git = null)
		{
			return Exe(new fs.folder_.git_.Top(workingDir), new _cfg_._remote.Name(remote), branch,git);
		}

		static public Task<int> Exe(
			nilnul.fs.FolderI workingDir
			, string remote
			, string branch
			, CancellationToken cancel
			, G git = null)
		{
			return Exe(new fs.folder_.git_.Top(workingDir), new _cfg_._remote.Name(remote),branch,cancel, git);
		}

	}
}
