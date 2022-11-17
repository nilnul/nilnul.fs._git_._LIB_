using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git.run_.ui
{

	[Obsolete(" for lurking, see: " + nameof(run_.lurk._CodX) + "; for cod, see: " + nameof(run._CodX))]

	static public class _ExitCodeX
	{
	

		static public int _ExitCode(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return nilnul.win.proc_.end.Cod.Singleton.cod(
				
				nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
				, _module
				
			);
			//return nilnul.win.prog.run._ExitCodeX.ExitCode(
			//	_module
			//	,
			//	nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			//	,
			//	arg
			//);
		}

		static public int ExitCode(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _ExitCode(
				module.top1.en.address.en
				,
				arg
				,git
			);
		}


		static public int _ExitCode_ofAddress(
			string module //git is supposed to run on a nonModule folder
			,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _ExitCode(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				arg
				,git
			);
		}



	}
}
