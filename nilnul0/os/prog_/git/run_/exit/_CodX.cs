using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git.run_.exit
{
	static public class _CodX
	{
		//static public program_._git.Result Result(nilnul.fs.git.ModuleI module, string arg, nilnul.win.program_.Git git=null) {
		//	return nilnul.win.program_.Git.RunCmd_result(module, arg, git);
		//}

		static public int _Cod_1argument(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git = null
		)
		{
			var t= _CodX_lurk._Cod_of1argument(_module,arg,git);
			Thread.Sleep(3*1000);
			return t;
		
		
		}

		static public int _Cod_ofArgument9cmd(
			
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _Cod_1argument(null,arg,git);
			
		}
		static public int _Cod_ofDir9argument9cmd(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _Cod_1argument(
				module.top1.en.address.en
				,
				arg
				,git
			);
		}


		static public int _Cod_ofDir9argument9cmd(
			string module //git is supposed to run on a nonModule folder
			,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _Cod_1argument(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				arg
				,git
			);
		}

		static public int _Cod_ofCmd9dir9args(
			nilnul.win.prog_.Git git ,

			string module //git is supposed to run on a nonModule folder
			,
			IEnumerable<string> args
			)
		{
			return _Cod_1argument(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				new nilnul.win.prog._run.Args1(
					args
				).ToString()
				,git
			);

		}

		static public int _Cod_ofCmd9dir9args(
			nilnul.win.prog_.Git git,

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			return _Cod_ofCmd9dir9args(git, module, (IEnumerable<string>)args);

		}
		static public int _Cod_ofDir9args(

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			return _Cod_ofCmd9dir9args(null, module, args);

		}
		static public int _Cod_ofDir9argument(

			string module //git is supposed to run on a nonModule folder
			,
			 string args
			)
		{
			return _Cod_ofDir9argument9cmd(module, args);

		}


	}
}
