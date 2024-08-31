using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo.push_.remote.branches_.all.exitCode_
{
	/// <summary>
	/// all branches
	/// </summary>
	static public class _UiTitledX
	{




		static public int Exe( nilnul.fs.git.Module workingDir, _cfg_._remote.Name remote, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run_.ui._ExitCodeX.ExitCode(workingDir, "push --all " + remote,git);    //all here means all branches.
		}

		static public int Exe( nilnul.fs.git.Module workingDir,string remote, nilnul.win.prog_.Git git=null)
		{
			return Exe(workingDir, new _cfg_._remote.Name(remote), git);
		}

		static public int Exe( string workingDir, string remote, nilnul.win.prog_.Git git=null)
		{
			return Exe( fs.git.Module.FroAddress(workingDir), new _cfg_._remote.Name(remote),git);
		}

	
		static public int Exe( nilnul.fs.folder_.git_.Top workingDir, _cfg_._remote.Name remote, G git=null)
		{
			return Exe(new Module(workingDir),remote,git);
			
		}


		static public int Exe( nilnul.fs.FolderI workingDir, string remote, G git=null)
		{
			return Exe(new fs.folder_.git_.Top(workingDir), new _cfg_._remote.Name(remote),git);
		}


		
	



		

	

	}
}
