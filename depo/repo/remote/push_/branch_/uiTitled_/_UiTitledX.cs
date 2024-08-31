using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.push_.remote_.branch_.uiTitled_
{

	/*Yes. nilnul.win.prog_.Git works by writing references in a manner that allows for this. If you are doing a commit at the same time as a push, push will only go from the references down to the objects they contain. If the commit finishes and updates the branch reference on time, it will get pushed. If it doesn't, the old reference will be pushed. You won't get "half a commit" pushed up.

All files are written in a manner that implicitly preserves referential integrity for any pointers. The last file written will be the reference that already has all it's dependencies there.*/
/// <summary>
/// windows titled
/// </summary>

	static public class _CodeWithMsgX
	{ 

		static public int ExitCode(
			nilnul.fs.git.Module folder,
			nilnul.fs.git.module.repo._cfg_._remote.Name remote
			, 
			nilnul.fs.git.module.repo._branch.Name branch
			,
			nilnul.win.prog_.Git git=null
		)
		{
			//Trace.TraceInformation($"now run pushing commnd of git for {folder}:{nameof(remote)}:{remote}, {nameof(branch)}:{branch}");
			return nilnul.win.prog_.git.run._ExitCodeX.ExitCode(folder, $"push {remote} {branch}",git);   
		}



		static public int ExitCode(nilnul.fs.git.Module folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{
			return ExitCode( (folder),new _cfg_._remote.Name(remote),new _branch.Name(branch), git);
			
		}

		static public int ExitCode(nilnul.fs.FolderI folder, string remote
			, string branch
			, nilnul.win.prog_.Git git=null)
		{
			return ExitCode(  Module.FroAddress(folder.address.ToString()), new _cfg_._remote.Name(remote), new _branch.Name(branch)
				,git
			);
		}

		static public int ExitCode(string folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{
			return ExitCode( Module.FroAddress(folder),new _cfg_._remote.Name(remote),new _branch.Name(branch), git);
			
		}
	}
}
