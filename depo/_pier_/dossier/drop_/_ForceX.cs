using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.dossier.drop_
{
	/// git-scm.com/docs/git-rm
	/// let's take depo as the context, to change pier;
	/// <summary>
	/// When --cached is given, the staged content has to match either the tip of the branch or the file on disk, allowing the file to be removed from just the index.
	/// <see cref="xpn_.ILossy"/>
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	static public class _ForceX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo">
		/// <see cref="fs.git.IDepo"/>
		/// </param>
		/// <param name="dossier">
		/// </param>
		/// <param name="git"></param>
		static public void _DropByForce_0depo_1dossier(
			string depo
			,
			string dossier
			,
			nilnul.os.prog_.Git git=null
		) {
			nilnul.os.prog_.git.run_.exit.result._Vow_codOkX._Vow_0address_2args(

				depo
				,
				git
				,
				$"rm"
				,"--cached",
				"-f" // without -f: Message=1:error: the following file has staged content different from both thefile and the HEAD: someFile1.ext(use -f to force removal)

				,$"{dossier}"
			); 
		}
	}
}