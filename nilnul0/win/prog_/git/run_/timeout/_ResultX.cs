using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git.run_.timeout
{
	/// <summary>
	/// timeout is implicit
	/// </summary>
	static public class _ResultX
	{
		//static public program_._git.Result Result(nilnul.fs.git.ModuleI module, string arg, nilnul.win.program_.Git git=null) {
		//	return nilnul.win.program_.Git.RunCmd_result(module, arg, git);
		//}
	
		static public nilnul.win.prog._run.Result Result(
			nilnul.fs.address_.ShieldI shield,
			string arg,
			nilnul.win.prog_.Git git = null
			,int? life=null
			,int? bye=null
			)
		{
			return nilnul.win.proc_.timeout_.end.Result.Singleton.result(
				win.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
				, 
				shield,life,bye);
			//return nilnul.win.prog.run_.nonShell_.redir_.both_.noUi_.wait._ResultX.Result(
			//	shield //.ToString()
			//	,
			//	nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
			//	,
			//	arg
			//);
			//return Result( new nilnul.fs.git.Module(module),arg,git);
		}

		static public nilnul.win.prog._run.Result Result_ofAddress(
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

		static public nilnul.win.prog._run.Result Result(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.win.prog_.Git git = null
			,int? life=null
			,int? bye=null
			
			)
		{
			return Result( (module.address.en),arg,git,life,bye);
		}

	static public nilnul.win.prog._run.Result Result(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			,int? life=null
			,int? bye=null
			
			)
		{
			return Result(module.top.en,arg,git,life,bye);

		}
		static public nilnul.win.prog._run.Result Result(
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
