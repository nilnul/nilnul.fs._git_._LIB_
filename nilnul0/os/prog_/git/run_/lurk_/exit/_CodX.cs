using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git.run_.lurk_.exit
{
	static public class _CodX
	{

		static public int _Cod_ofAddress_lurkAssumeNum(
			string _module,
			string arg,
			nilnul.os.prog_.Git git 
			,
			int lurk
			)
		{
			return new nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited.Cod(lurk).ofAddress(
				nilnul.os.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
				,
				_module
			);
			//return nilnul.win.prog.run._ExitCodeX.ExitCode(
			//	_module
			//	,
			//	nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			//	,
			//	arg
			//);
		}
		static public int _Cod_lurkAssumeNum(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.os.prog_.Git git 
			,
			int lurk
			)
		{
			return _Cod_ofAddress_lurkAssumeNum(
				_module.ToString()
				,
				arg
				,
				git
				,
				lurk
			);
			//return nilnul.win.prog.run._ExitCodeX.ExitCode(
			//	_module
			//	,
			//	nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			//	,
			//	arg
			//);
		}

		static public int _Cod_lurkAssumeNum(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git 
			,
			int lurk
			)
		{
			return
				_Cod_lurkAssumeNum(
					_module
					,
					arg
					,
					(os.prog_.Git)git
					,
					lurk
				);
		}


		static public int _ExitCode(
			nilnul.fs.address_.ShieldI _module,
			string arg,
			nilnul.win.prog_.Git git = null
			,
			int? lurk=null
			)
		{
			return _Cod_lurkAssumeNum(
				_module
				,
				arg
				,
				nilnul.os.prog_.git.nulable.Fallback.NotNul(git)
				,
				os.Properties.SettingsX._Lurk(lurk)

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
		static public int _Cod_ofAddress_ofArgument_lurkAssumeNum(
			string module //git is supposed to run on a nonModule folder
			,
			string arg
			,
			nilnul.win.prog_.Git git = null
			,
			int? lurk=null

			)
		{
			return _ExitCode(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				arg
				,git
				,
				lurk
			);
		}
		static public int _Cod_ofAddress_ofArgument_lurkAssumeNum(
			string module //git is supposed to run on a nonModule folder
			,
			string arg
			,
			int lurk

			)
		{
			return _Cod_ofAddress_lurkAssumeNum(
				 module
				,
				arg
				,nilnul.os.prog_.git.nulable.Fallback.NotNul()
				,
				lurk
			);
		}





	}
}
