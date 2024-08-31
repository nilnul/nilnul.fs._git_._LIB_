using nilnul.win.prog._run;
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

		static public int _Cod_0address_1argument(
			string _module,
			string argument,
			nilnul.win.prog_.Git git = null
		)
		{
			return _CodX_lurk._Cod_0address_1argument(_module,argument,git);
		
		}
		static public int _Cod_assumeAddress_assumeArgument(
			string _module,
			string arg,
			nilnul.win.prog_.Git git = null
		)
		{
			return _CodX_lurk._Cod_assumeAddress_assumeArgument(_module,arg,git);
		
		}

		static public int _Cod_1argument(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Cod_assumeAddress_assumeArgument(_module.ToString(),arg,git);
		
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="module">to be converted to a shield</param>
		/// <param name="arg"></param>
		/// <param name="git"></param>
		/// <returns></returns>
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

		static public int _Cod_2address(
			nilnul.win.prog_.Git git
			,
			win.prog._run.Args1 args
			,

			string module //git is supposed to run on a nonModule folder
			)
		{
			return _Cod_0address_1argument(
				 (module)
				,
				
				args.ToString()
				,
				git
			);
		}
		static public int _Cod_1address(
			nilnul.win.prog_.Git git
			,

			string module //git is supposed to run on a nonModule folder
			,
			IEnumerable<win.prog._run.Arg1> args

		)
		{
			return _Cod_2address(
				git
				,
				new nilnul.win.prog._run.Args1(
					args
				)
				,
				 module
			);
		}
		static public int _Cod_2address(
			nilnul.win.prog_.Git git
			,
			IEnumerable<win.prog._run.Arg1> args
			,

			string module //git is supposed to run on a nonModule folder

		)
		{
			return _Cod_2address(
				git
				,
				new nilnul.win.prog._run.Args1(
					args
				)
				,
				 module
			);
		}


		static public int _Cod_1args_2address(
			nilnul.win.prog_.Git git
			,
			IEnumerable<string> args
			,

			string module //git is supposed to run on a nonModule folder
			)
		{
			return _Cod_2address(
				git
				,
				args.Select(a=> new Arg1(a))
				,
				 module
			);
		}


		[Obsolete(nameof(_Cod_1args_2address))]
		static public int _Cod_1address_2args(
			nilnul.win.prog_.Git git ,

			string module //git is supposed to run on a nonModule folder
			,
			IEnumerable<string> args
			)
		{
			return _Cod_1address(
				git,
				 (module)
				,
				(
					args
				).Select(a=> new Arg1(a))
			);
		}

		static public int _Cod_1address_2args(
			nilnul.win.prog_.Git git,

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			return _Cod_1address_2args(git, module, (IEnumerable<string>)args);

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

		public static int _Cod_0address_1args(string module, string[] args)
		{
			return _Cod_1args_2address(null,args,module);
		}
	}
}
