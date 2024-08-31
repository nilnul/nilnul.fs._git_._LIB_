using nilnul.fs.git.module._work_.documents_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.untracked_._unignored_.by_
{
	/// 
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///	vs:
	///		<see cref="untracked_._UnignoredX"/>
	///
	static  class _ByLsFilesX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// vs: <see cref="_IncludedX"/>, where "-c" means from cache.
		static public os.proc_.finished._result.CodMsgErr Get4result(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {

			return nilnul.os.prog_.git.run_.exit._ResultX.Result_ofAddress(
				depo
				,
				"ls-files -o --exclude-standard" // return every document in werk that is included, tracked0untracked; excluding: deleted, even if it's in stage.
				/// todo: maybe wrong
				/// , <see cref="dossiers_._IncludedX"/>

				,
				git
			);

		}
	}
}
