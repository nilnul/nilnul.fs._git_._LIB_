using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.repo.top_.byRevParse_
{
	static public class _AbsX
	{
		static public string Address_assumeRepoAddress(string _repoAddress, Git git = null)
		{
			var r = nilnul.win.prog_.git.run_.timeout._ResultX.Result_ofAddress(
				_repoAddress
				,
				"rev-parse --absolute-git-dir"
			);/*
			for repo
					in top folder, ret the path
					in directory, ret absolute path
			for work
				return ".git"'s absolute path
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


		static public string Address_assumeRepo(nilnul.fs.FolderI _repoAddress, Git git = null)
		{
			return Address_assumeRepoAddress(_repoAddress.ToString(), git);
		}

		static public address_.Shield Shield_assumeRepo(
nilnul.fs.FolderI _repoAddress, Git git = null
		) {
			return nilnul.fs.address_.Shield.FroAddress(
				Address_assumeRepo(_repoAddress,git)
			);
		}


		static public address_.Shield Shield_assumeRepoAddress(
				string _repoAddress,
				Git git = null
		) {
			return nilnul.fs.address_.Shield.FroAddress(
				Address_assumeRepoAddress(_repoAddress,git)
			);
		}


	}
}
