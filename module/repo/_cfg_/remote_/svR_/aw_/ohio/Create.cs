using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_._remote_.aw_.ohio
{
	static public class _CreateX
	{
		static public void RetVoid(nilnul.fs.FolderI _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git=null)
		{
			RetVoid( 
				new nilnul.fs.folder_.git_.Top(_gitTop), remoteName,repoName
			);
		}

		static public void RetVoid(nilnul.fs.folder_.git_.Top _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git = null)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				remoteName
				,
				nilnul.fs.git.svr_.aw_.ohio.repo._UrlX.Create(repoName)
				,git
			);
		}
	}
}