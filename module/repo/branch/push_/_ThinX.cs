using nilnul.dev.git;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.push_
{
	/// <summary>
	/// use the thin parameter for slow network.
	/// </summary>
	static public class _ThinX
	{
		static public void Void(
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remote
			, nilnul.fs.git.module.repo._branch.Name branch
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(folder, $"push --thin {remote} {branch}", git);
		}

		private static void Void(Module module, string remote, string branch, Git git)
		{
			Void(module,new _cfg_._remote.Name(remote), new _branch.Name(branch),git);
		}

		static public void RemoteBranchThin(nilnul.fs.Folder folder, string remote, string branch, Git git = null)
		{

			Void( new Module(folder),remote,branch,git);
		}

	}
}
