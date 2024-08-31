using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_._remote_.bb.create_
{
	static public class _CfgedX
	{
		static public void Void(nilnul.fs.FolderI _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git=null)
		{
			Void( 
				new nilnul.fs.folder_.git_.Top(_gitTop), remoteName,repoName
			);
		}

		static public void Void(nilnul.fs.folder_.git_.Top _gitTop, string remoteName, string repoName,nilnul.win.prog_.Git git = null)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				remoteName
				,
				nilnul.fs.git.svr_.bb.client_.cfged.repo._UrlX.Gen(repoName)
				,git
			);
		}
	}
}