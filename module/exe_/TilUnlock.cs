using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.exe_
{
	[Obsolete("if there is 'config.lock', this is looped infinitely", true)]
	public class _TilUnlockX
	{
		static public void TilUnlock(
			ModuleI shield
			,
			nilnul.win.prog_.Git git = null
		)
		{
			while (nilnul.fs.git.module.be_._LockedX.Be(shield, git))
			{

				//System.Console.WriteLine($"locked at {shield} at {DateTime.UtcNow}");

				Trace.TraceWarning($"locked at {shield} at {DateTime.UtcNow}");

				Task.Delay(2 * 1000).Wait();

			}
		}

		static public void _TilUnlock_ofTopAddress(
			string shield
			,
			nilnul.win.prog_.Git git = null
		)
		{
			TilUnlock( Module.FroAddress(shield),git);
		}

	}
}
