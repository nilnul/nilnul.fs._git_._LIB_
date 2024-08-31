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
			return _ExitCode_0moduleAddress(_module.top1.en.address.en.ToString());
			//fs.git.module.repo.unlock_.wait._TimeoutX._Timeout_addressAssumeModule(_module.ToString());

			//return nilnul.win.prog_.git.run._ExitCodeX.ExitCode(
			//	_module
			//	, 
			//	"add -A"   //--all
			//	,
			//	git
			//);
		}

		static public int _ExitCode_0moduleAddress( string _moduleAddress , nilnul.win.prog_.Git git=null)
		{
			//fs.git.module.repo.unlock_.wait._TimeoutX._Timeout_addressAssumeModule(_module.ToString());

			return nilnul.os.prog_.git.run_.lurk_.exit._CodX._ExitCode_ofAddress(
				_moduleAddress
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
