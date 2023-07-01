using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.branch_.current._upstream
{
	/*Set the preferred remote for the current (checked out) branch:

git branch --set-upstream-to <remote-name>
*/
	static public class _CfgX
	{
		static public void Cfg(nilnul.fs.FolderI folder
			, nilnul.fs.git.module.repo._cfg_._remote.Name remote
			,

			nilnul.win.prog_.Git git = null
		)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				folder
				,
				$"branch --set-upstream-to {remote}"
				,
				git
			);
		}
	}
}
