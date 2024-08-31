using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.destinys_._included_.by_
{
	
	static public class _ExcludeDefaultedX
	{
		/// <summary>
		/// including dossier ( including symlink dir )
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<string> _GetDossiers_0depo(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo
					,
					"ls-files -oc" //	 //seems " --exclude-standard" is defaulted;
					,
					git
				)
			);
		}
	}
}
