using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.repo.top_
{
	static public class _ByRevParseX
	{
		static public string Address_ofAddress(string _repoAddress, Git git = null)
		{
			var r = nilnul.win.prog_.git.run_.timeout._ResultX.Result_ofAddress(
				_repoAddress
				,
				"rev-parse --git-dir"
			);/*
			for repo
					in top folder, ret "."
					in directory, ret absolute path
			for work
				return ".git"
			for plain folder,
					return "fatal <...>", 128
			 */



			if (r.msg.Trim() == "."
				)
			{
				return _repoAddress;
			}
			else
			{
				return r.msg.Trim();
			}

		}


		static public string Address(nilnul.fs.FolderI _repoAddress, Git git = null)
		{
			return Address_ofAddress(_repoAddress.ToString(), git);
		}

		static public address_.Shield Shield(
nilnul.fs.FolderI _repoAddress, Git git = null
)
		{
			return nilnul.fs.address_.Shield.FroAddress(
				Address(_repoAddress, git)
			);
		}



	}
}
