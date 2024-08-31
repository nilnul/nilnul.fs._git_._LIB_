using System;
using System.Diagnostics;

namespace nilnul.fs.git.depo.pier_.wet._bak_.hence
{
	/// <summary>
	/// the inPlace bak has been done, which might already be an orphanated branch.
	/// if it's already an orphan, here we do nothing. 
	///
	/// now we do a commit into orphaned branch.
	/// </summary>
	static public class _AloneX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="bakBatch"></param>
		/// <param name="git"></param>
		/// <returns>
		/// the pierAhead, and, if the head is hatched, the orphaned pierBak;
		/// </returns>
		/// <exception cref="Exception"></exception>
		/// <exception cref="fs.git.repo.act_.xpn_.FsAccessDenied"></exception>
		/// 
		static public string[] _Tags_0depo8dirty_1head_2bak(
			string depo
			,string oldHead
			,
			string bakBatch
			,
			nilnul.os.prog_.Git git = null
		)
		{

			var t=_HenceX._Tag_0depo8dirty_1head_2bak(depo,oldHead,bakBatch,git);

			var pier8orphan=_alone._OrphanX._Tag0nul_0depo8wet_1head_2bak(depo,oldHead,bakBatch,git);
			if (pier8orphan is null)
			{
				return [t];
			}
			return [t,pier8orphan];

			//return (pier8head: t, pier8orphan0nul :pier8orphan);
	



		}
	}
}
