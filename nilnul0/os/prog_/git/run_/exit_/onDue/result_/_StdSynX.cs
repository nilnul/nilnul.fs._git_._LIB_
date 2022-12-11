using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git.run_.exit_.onDue.result_
{
	/// <summary>
	/// timeout is implicit
	/// </summary>
	static public class _StdSynX
	{
		//static public program_._git.Result Result(nilnul.fs.git.ModuleI module, string arg, nilnul.win.program_.Git git=null) {
		//	return nilnul.win.program_.Git.RunCmd_result(module, arg, git);
		//}
	
		static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.address_.ShieldI shield,
			string arg,
			nilnul.win.prog_.Git git = null
			,int? life=null
			,int? bye=null
			,int? waitAftKill=null

			)
		{
			return
				nilnul.os.prog.run_.exit_.onDue.result_.StdSyn.Singleton.ofAddress

				(
				nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
				, 
				shield.ToString(),life,bye,waitAftKill);
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
			,int? life=null
			,int? bye=null
			)
		{
			return Result(
				 nilnul.fs.address_.shield_._AddressX1.Create(module)
				,
				arg
				,git,life,bye
			);
		}

		static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.win.prog_.Git git = null
			,int? life=null
			,int? bye=null
			
			)
		{
			return Result( (module.address.en),arg,git,life,bye);
		}

	static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			,int? life=null
			,int? bye=null
			
			)
		{
			return Result(module.top.en,arg,git,life,bye);

		}
		static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.Module module,
			string arg,
			nilnul.win.prog_.Git git = null
			,int? life=null
			,int? bye=null
		)
		{
			return Result((nilnul.fs.git.ModuleI)module,arg,git ,life,bye);
		}



	}
}
