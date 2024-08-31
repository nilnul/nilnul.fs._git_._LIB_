using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.destinys_
{
	/// as a comming commit
	/// <summary>
	/// git ls-files --others --cached --exclude-standard
	/// # in short:
	/// git ls-files -oc --exclude-standard
	/// including:
	///		untrackedUnignored, tracked
	///	excluding:
	///			untracked&(ignored|excluded)
	/// </summary>
	/// <remarks>
	/// included by cache:
	///		, if a file is in both werk and cache, then it's listed;
	///		,if a file is removed from the werk, but still in the head snapshort, then the file is still listed.<see cref="fs.git.depo._werk_.dossiers_._IncludedX"/>
	/// 
	/// if a file is in the werk, but not in the head snapshort, then the file, if not ignored, is still listed.<see cref="_werk_.dossiers_.untracked_._UnignoredX"/> or by <see cref="_werk_.dossiers_.untracked_.IUnignored"/>.
	/// 	
	/// if a file is removed from the werk, and also removed from the index, it's not listed.
	///
	/// </remarks>
	/// 
	/// 
	/// 
	static public class _IncludedX
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
					"ls-files -oc --exclude-standard" //	 //seems to include tracked unchanged files;
					,
					git
				)
			);
		}
	}
}
