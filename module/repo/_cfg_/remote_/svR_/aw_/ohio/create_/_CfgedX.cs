using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_._remote_.aw.create_
{
	static public class _CfgecX
	{
		static public void RetVoid(nilnul.fs.folder_.git_.Top _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git = null)
		{
			aw_.ohio._CreateX.RetVoid(
				_gitTop, nilnul.fs.git.Properties.Settings.Default.moduleRemoteKeysAw.Cast<string>().Last()
				,
				repoName,git
			);
		}

		static public void RetVoid(nilnul.fs.FolderI _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git=null)
		{
			RetVoid( 
				new nilnul.fs.folder_.git_.Top(_gitTop), remoteName,repoName
			);
		}

	}
}