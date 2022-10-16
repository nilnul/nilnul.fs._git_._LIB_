using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.add_.all_
{
	/// <summary>
	/// including：
	///		removed,
	///		updated, 
	///		new but not tracked
	///	not including:
	///		ignored
	/// </summary>
	static public class _MinWinTitledX
	{
		static public int ExitCode( nilnul.fs.git.ModuleI _module , nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run._ExitCodeX.ExitCode(
				_module
				, 
				"add -A"   //--all
				,
				git
			);
		}

		

		static public int ExitCode( string _module , nilnul.win.prog_.Git git=null)
		{
			return ExitCode(nilnul.fs.git.Module.FroAddress(_module),git);
		}

	}
}
