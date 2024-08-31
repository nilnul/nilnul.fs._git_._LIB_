using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.repo.division._length
{
	internal class Limit
	{
		/// <summary>
		/// when breached:
		/// VS403729: The push was rejected because commit '6fbe8dc700fdb33ef512e2b9e35436faf555de76' contains a path, which exceeds the maximum length of 32766 characters.
		/// </summary>
		//[global::System.Configuration.UserScopedSettingAttribute()]
		//[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		//[global::System.Configuration.DefaultSettingValueAttribute("32766")]
		static public int svr__azure_repo_division__length_Limit_full
		{
			get
			{
				return nilnul.fs.git.Properties.Settings.Default.svr__azure_repo_division__length_Limit_full;
			}
		}


		/// <summary>
		/// when breached:
		/// VS403729: The push was rejected because commit 'd23277abfe2d8dcbb88456da880de631994dabb4' contains a path component, which exceeds the maximum length of 4096 characters.
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		//[global::System.Configuration.UserScopedSettingAttribute()]
		//[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		//[global::System.Configuration.DefaultSettingValueAttribute("4096")]
		static public int svr__azure_repo_div_dnt__length_Limit_full
		{
			get
			{

				return nilnul.fs.git.Properties.Settings.Default.svr__azure_repo_div_dnt__length_Limit_full;

			}
		}
	}
}
