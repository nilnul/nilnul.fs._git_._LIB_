using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git.run
{
	static public class _CodX
	{
		//static public program_._git.Result Result(nilnul.fs.git.ModuleI module, string arg, nilnul.win.program_.Git git=null) {
		//	return nilnul.win.program_.Git.RunCmd_result(module, arg, git);
		//}

		static public int _ExitCode(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			//return nilnul.win.proc_.finish.Cod.Singleton.cod(
			//	nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			//	,
			//	arg
			//	, _module

			////,30*1000
			//);
			return os.prog_.git.run_.exit._CodX_lurk._Cod_of1argument(_module,arg,git);
		}

		static public int _ExitCode(
			
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _ExitCode(null,arg,git);
			
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

		static public int _ExitCode_ofAddress(
			nilnul.win.prog_.Git git ,

			string module //git is supposed to run on a nonModule folder
			,
			IEnumerable<string> args
			)
		{
			return _ExitCode(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				new nilnul.win.prog._run.Args1(
					args
				).ToString()
				,git
			);

		}

		static public int _ExitCode_ofAddress(
			nilnul.win.prog_.Git git,

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			return _ExitCode_ofAddress(git, module, (IEnumerable<string>)args);

		}
		static public int _ExitCode_ofAddress(

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			return _ExitCode_ofAddress(null, module, args);

		}


	}
}
