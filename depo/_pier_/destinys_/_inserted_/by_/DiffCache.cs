using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.destinys_._inserted_.by_
{
	/// <summary>
	/// git diff --cached. With --name-only it'll list all the files you've changed in the index relative to HEAD. With --name-status you can get the status symbol too, with --diff-filter you can specify which set of files you want to show ('A' for newly added files, for instance). Use -M to turn on move detection and -C for copy detection if you want them.
	/// </summary>
	internal class DiffCache
	{
		static public string Msg(string depo) {
			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo
				,
				"git diff --cached --name-only  --diff-filter=A"
			);
		}
	}
}
