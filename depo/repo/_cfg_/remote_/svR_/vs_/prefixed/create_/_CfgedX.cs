using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_._remote_.vs_.prefixed.create_
{
	static public class _CfgedX
	{
		static public void RetVoid(nilnul.fs.FolderI _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git=null)
		{
			RetVoid( 
				new nilnul.fs.folder_.git_.Top(_gitTop), remoteName,repoName
			);
		}

		static public void RetVoid(nilnul.fs.folder_.git_.Top _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git = null)
		{
			_CreateX.RetVoid(
				nilnul.fs.git.Properties.Settings.Default.svr_vs__prefix,
				_gitTop, 
				remoteName,
				repoName,
				git
			);
		}
	}
}