using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git.run
{
	/// <summary>
	/// timeout is implicit
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.os.prog_.git.run_.exit._ResultX))]
	static public class _ResultX1
	{
		//static public program_._git.Result Result(nilnul.fs.git.ModuleI module, string arg, nilnul.win.program_.Git git=null) {
		//	return nilnul.win.program_.Git.RunCmd_result(module, arg, git);
		//}
		static public os.proc_.finished._result.CodMsgErr _Result_assumeAddress(
			string shield
			,
			string arg
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return os.prog_.git.run_.exit._ResultX.Result_ofAddress
				//nilnul.win.proc_.started_.end.result_.StdSyn.Singleton.ofAddress
				//nilnul.os.prog.run_.ended.result_.StdSyn.Singleton.ofAddress
				(
				shield,
				
				arg
				,
				git
			);

			//return nilnul.win.prog.run_.nonShell_.redir_.both_.noUi_.wait._ResultX.Result(
			//	shield //.ToString()
			//	,
			//	nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			//	,
			//	arg
			//);
			//return Result( new nilnul.fs.git.Module(module),arg,git);
		}

	
		static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.address_.ShieldI shield,
			string arg,
			nilnul.win.prog_.Git git = null
		)
		{
			return  os.prog_.git.run_.exit._ResultX.Result
//nilnul.win.proc_.started_.end.result_.StdSyn.Singleton.result
				(
				shield
				,
				arg
				,
				git
			);

			//return nilnul.win.prog.run_.nonShell_.redir_.both_.noUi_.wait._ResultX.Result(
			//	shield //.ToString()
			//	,
			//	nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			//	,
			//	arg
			//);
			//return Result( new nilnul.fs.git.Module(module),arg,git);
		}

		static public os.proc_.finished._result.CodMsgErr Result_ofAddress(
			string module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Result(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				arg
				,git
			);
		}
		[Obsolete()]
		static public string MsgOrNul_ofAddress(
			string module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			var r= Result(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				arg
				,git
			);
			return r.beErr ? null : r.msg;
		}

		static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Result( (module.address.en),arg,git);
		}

	static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Result(module.top.en,arg,git);

		}
		static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.Module module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Result((nilnul.fs.git.ModuleI)module,arg,git);
		}



	}
}
