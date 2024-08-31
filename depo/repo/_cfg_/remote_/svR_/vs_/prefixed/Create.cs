using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_._remote_.vs_.prefixed
{
	static public class _CreateX
	{
		static public void RetVoid(string prefix,nilnul.fs.FolderI _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git=null)
		{
			RetVoid( 
				prefix,
				new nilnul.fs.folder_.git_.Top(_gitTop), remoteName,repoName
			);
		}

		static public void RetVoid(string prefix, nilnul.fs.folder_.git_.Top _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git = null)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				remoteName
				,
				nilnul.fs.git.svr_.vs_.prefixed.repo._UrlX.Gen(prefix,repoName)
				,git
			);
		}
	}
}