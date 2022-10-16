using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_._remote.create_
{
	[Obsolete()]
	static public class _AwsX
	{

		static public void RetVoid(nilnul.fs.Folder _gitTop, string remoteName, string repoName, nilnul.win.prog_.Git git = null)
		{


			RetVoid(
				new nilnul.fs.folder_.git_.Top(_gitTop), remoteName, repoName
			);

		}

		static public void RetVoid(nilnul.fs.folder_.git_.Top _gitTop, string remoteName, string repoName, nilnul.win.prog_.Git git = null)
		{


			nilnul.fs.git.module._cfg_._remote._CreateX.RetVoid(
				_gitTop
				,
				remoteName
				,
				nilnul.fs.git.svr_.aws_.usEast2.repo._UrlX.Create(repoName)
				, git
			);

		}

	}
}
