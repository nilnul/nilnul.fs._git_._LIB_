using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace nilnul.fs.git.module.repo.branch_.vered_.nub_.newest_.noncurrent
{
	/// <summary>
	/// if the last two bakBranches are same in contents, delete the last one, 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// alias:
	///		regress
	///		
	///		idempotent
	public static class _RegressX
	{
		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>the branch of the latest content.</returns>
		public static string _Regress_addressAssumeModule_branchAssumeNewest(
			string _location
			,
			string newBakBranch
			,
			nilnul.os.prog_.Git git = null)
		{
			//string bakBranch=null;
			//string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul.dev.bak.Properties.Settings.Default.branchBak);
			string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(newBakBranch);


			txt_.Vered prevNulable = nilnul.fs.git.module.repo.branch_.vered_.key.delNewIfSame._RetPrevIfDelElseNulX.PrevNulabe_ofModuleAddress(
				_location
				,
				$"{bakVeredKey}"

				, git
			);

			if (prevNulable != null)
			{
				newBakBranch = prevNulable;
				Trace.TraceWarning($"{typeof(_RegressX).FullName}.{nameof(_Regress_assumeModule_branchAssumeNewest)}({_location}): bakBranch changed to {prevNulable}");
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
			return _Regress_addressAssumeModule_branchAssumeNewest(_module.ToString(), bakBranch, git);
		}
	}
}
