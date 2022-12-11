using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git.prep_.shell_.win_.min.proc_.started_.waited
{
	static public class _CodX
	{
		//static public program_._git.Result Result(nilnul.fs.git.ModuleI module, string arg, nilnul.win.program_.Git git=null) {
		//	return nilnul.win.program_.Git.RunCmd_result(module, arg, git);
		//}

		static public int _Cod_ofCmd9argument9dir(
			string git
					,
			string args
			,
			string dir //git is supposed to run on a nonModule folder
		)
		{
			return
				//nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited._CodX.OfAddress // it's the process responsibility to end gracefully
				nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.exit._CodX._ExitCode
				(
				git
				,
				args
				,
				dir
			);

		}
		static public int _Cod_ofCmd9argument9dir(
			nilnul.os.prog_.Git git
					,
			string args
			,
			string dir //git is supposed to run on a nonModule folder
		)
		{
			return _Cod_ofCmd9argument9dir(git.location.ToString(),args,dir);

		}

	


		static public int _Cod_ofCmd9dir9argument(
			string git,

			string dir //git is supposed to run on a nonModule folder
			,
			string args
		)
		{
			return _Cod_ofCmd9argument9dir(git,args,dir)				;

		}


		static public int _Cod_of1argument(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
		
			/// we need to make it timeout, as it seems that the window failed to reshow;
			/// 
			return _Cod_ofCmd9argument9dir
				//nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited._CodX.OfAddress // it's the process responsibility to end gracefully
				//nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_.waited._CodX.OfAddress
				(
				nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
				,
				_module.ToString()
			);
		}

		static public int _Cod_ofArgument9cmd(
			
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _Cod_of1argument((fs.address_.ShieldI)null, arg, git);
			
		}
		static public int _Cod_of1argument(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _Cod_of1argument(
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
			return _Cod_of1argument(
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
			return _Cod_of1argument(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				new nilnul.win.prog._run.Args1(
					args
				).ToString()
				,git
			);

		}

		static public int _Cod_ofCmd9dir9args(
			nilnul.os.prog_.Git git,

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			return _Cod_ofCmd9dir9args(git, module, (IEnumerable<string>)args);
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

		static public int _Cod_ofDir9argument(

			string module //git is supposed to run on a nonModule folder
			,
			 string args
			)
		{
			return _Cod_ofDir9argument9cmd(  module, args,null);

		}
	


		static public int _Cod_ofDir9args(

			string module //git is supposed to run on a nonModule folder
			,
			params string[] args
			)
		{
			return _Cod_ofCmd9dir9args((nilnul.os.prog_.Git)null, module, args);

		}

	}
}
