using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git.run_.exit_.onDue.result_
{
	/// <summary>
	/// </summary>
	static public class _Wait4unlock_assumeModuleX
	{
	
		static public proc_.finished._result.CodMsgErr _Result_assumeAddress(
			string shield,
			string arg,
			nilnul.os.prog_.Git git = null
			,int? life=null
			,int? bye=null
			//,int? waitAftKill=null

			)
		{
			fs.git.module.repo.unlock_.wait._ForceX._ForceAsTask_addressAssumeModule(shield);
			return _ResultX._Result_assumeAddress(
				shield
				,

				arg
				, 
				git
				,
				life
				,
				bye
			);
			
		}
		static public proc_.finished._result.CodMsgErr Result(
			nilnul.fs.address_.ShieldI shield,
			string arg,
			nilnul.os.prog_.Git git = null
			,int? life=null
			,int? bye=null
			//,int? waitAftKill=null

			)
		{
			fs.git.module.repo.unlock_.wait._ForceX._ForceAsTask_addressAssumeModule(shield.ToString());
			return _ResultX.Result(
				shield
				,

				arg
				, 
				git
				,
				life
				,
				bye
			);
			
		}

		static public proc_.finished._result.CodMsgErr Result_ofAddress(
			string module,
			string arg,
			nilnul.os.prog_.Git git = null
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

		static public proc_.finished._result.CodMsgErr Result(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.os.prog_.Git git = null
			,int? life=null
			,int? bye=null
			
			)
		{
			return Result( (module.address.en),arg,git,life,bye);
		}

	static public proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.os.prog_.Git git = null
			,int? life=null
			,int? bye=null
			
			)
		{
			return Result(module.top.en,arg,git,life,bye);

		}
		static public proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.Module module,
			string arg,
			nilnul.os.prog_.Git git = null
			,int? life=null
			,int? bye=null
		)
		{
			return Result((nilnul.fs.git.ModuleI)module,arg,git ,life,bye);
		}



	}
}
