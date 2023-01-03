using nilnul.fs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.gitk
{
	static public class _RunX
	{
		static public void _Vod_assumeAddress_ofArgument(
			string _module
			,
			string arg
			,
			nilnul.os.prog_.Gitk git = null

		)
		{
			Process.Start(
				new ProcessStartInfo(
				   nilnul.os.prog_.gitk.nulable.Fallback.NotNul(git).val.location
				   ,
				   arg
				)
				{
					WorkingDirectory = _module
				}
		   );
		}

		static public void _Vod_ofArgument(
			string arg
			,
			nilnul.win.prog_.Git git = null
		)
		{
			Process.Start(
				new ProcessStartInfo(
			   nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			   ,
			   arg
			   )
			);
		}
	}
}
