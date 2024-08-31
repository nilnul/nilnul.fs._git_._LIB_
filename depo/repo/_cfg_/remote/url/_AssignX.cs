using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.url
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		ensure
	///		update
	///		upsert
	///		set
	static public class _AssignX
	{

		/*
		 git remote set-url origin git@github.com:<username>/<project>.git

			Internally, the git remote set-url command calls git config remote, but has the added benefit of reporting back any errors. git config remote on the other hand, will silently fail if you mistype an argument or option and not actually set anything. 

			fatal: No such remote '<given remote>' if no such remote.

			 */
		static public void ByRemoteCmd(Folder folder, string remote, string url, Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void( folder, $"remote set-url {remote} {url}",git);


		}

		static public void ByRemoteCmd(string folder, string remote, string url, Git git=null)
		{
			ByRemoteCmd(
				nilnul.fs.Folder.FroAddress(folder)
				,
				remote,
				url
				,git
			);


		}


	}


}
