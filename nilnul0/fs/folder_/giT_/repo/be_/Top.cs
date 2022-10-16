using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.repo.be_
{
	/**/

	/// <summary>
	/// inside the repo, are we in the base folder or subfolder or directory (not the topmost directory.)? 
	/// </summary>
	static public class _TopX
	{
		static public bool _Be_assumeRepoAddress(string _repoAddress, Git git = null)
		{
			var r = nilnul.win.prog_.git.run_.timeout._ResultX.Result_ofAddress(
				_repoAddress
				,
				"rev-parse --git-dir"
				,git
			);/*
			for repo
					in top folder, ret "."
					in directory, ret absolute path
			for work
				return ".git"
			for plain folder,
					return "fatal <...>", 128
			 */


			return r.msgThrowErr.Trim() == ".";

			
		}
		static public bool _Be_assumeRepo(nilnul.fs.FolderI _repoAddress, Git git = null)
		{
			return _Be_assumeRepoAddress(_repoAddress.ToString(), git);
		}

	}
}
