using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace nilnul.fs.git.depo.repo.branch_.vered_.nob_.newest_.noncurrent.retract_
{
	/// <summary>
	/// if the last two bakBranches are same in contents, and the previous one is not orphan, delete the last one, 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// alias:
	///		regress
	///		
	///		idempotent
	public static class _ToNonOrphanX
	{
		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>the branch of the latest content.</returns>
		public static string _Regress_0moduleAddress_1branchNewestNoncurrent(
			string _location
			,
			string newBakBranch
			,
			nilnul.os.prog_.Git git = null)
		{
			//string bakBranch=null;
			//string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul.dev.bak.Properties.Settings.Default.branchBak);
			string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(newBakBranch);


			txt_.Vered prevNulable = _nonorphan._RetPrev8delOrNulX.PrevNulabe_ofModuleAddress(
				_location
				,
				$"{bakVeredKey}"

				, git
			);

			if (prevNulable != null)
			{
				newBakBranch = prevNulable;
				Trace.TraceWarning($"{typeof(_ToNonOrphanX).FullName}.{nameof(_Regress_assumeModule_branchAssumeNewest)}({_location}): bakBranch changed to {prevNulable}");
			}
			return newBakBranch;
		}

		public static string _Regress_assumeModule_branchAssumeNewest(
			fs.FolderI _module
			,
			string bakBranch
			, nilnul.os.prog_.Git git = null
		)
		{
			return _Regress_0moduleAddress_1branchNewestNoncurrent(_module.ToString(), bakBranch, git);
		}
	}
}
