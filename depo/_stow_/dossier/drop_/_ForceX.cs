using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.dossier.drop_
{
	/// <summary>
	/// if <see cref="fs.git.depo._pier_.dossier_.IEnhancedVsHead"/>
	/// exitCod: 1;
	/// error: the following file has changes staged in the index: someFile1.ext(use --cached to keep the file, or -f to force removal)
	/// </summary>
	/// <remarks>
	/// can remove: <see cref="fs.git.depo._pier_.dossier_.IEnhancedVsHead"/>
	/// </remarks>
	/// alias:
	///		_EnhancedInPierX
	///	vs:
	///		<see cref="fs.git.depo._pier_.dossier.Devoid"/>
	static public class _ForceX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo">
		/// <see cref="fs.git.IDepo"/>
		/// </param>
		/// <param name="dossier">
		/// exists both in werk and pier;
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
				$"rm","-f",$"{dossier}"
			);

		}
	}
}
