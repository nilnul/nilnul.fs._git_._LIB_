using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.snap
{
	static public class _VwX
	{
		/*
		 git rev-parse refs/heads/master 
		 
		   don't append -- or else "--" will be shown at the end of the result if the ref exists.
		   error code is 128 if the ref doesn't exist
		 */

		static public os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.ModuleI module,
			nilnul.fs.git.repo._reference.Name reference
			,
			nilnul.win.prog_.Git git=null
			,
			int? timeout_milliseconds=null
		)
		{
			return nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(module, $"rev-parse {reference}", git, timeout_milliseconds??5000);
		}

		static public string Msg(
			nilnul.fs.git.ModuleI module,
			nilnul.fs.git.repo._reference.Name reference
			,
			nilnul.win.prog_.Git git=null
			,
			int? timeout_milliseconds=null
		)
		{
			return nilnul.os.proc_.finished._result.data._MsgX.Msg( Result(module,reference,git,timeout_milliseconds));
		}
		static public string MsgNul(
			nilnul.fs.git.ModuleI module,
			nilnul.fs.git.repo._reference.Name reference
			,
			nilnul.win.prog_.Git git=null
			,
			int? timeout_milliseconds=null
		)
		{
			return nilnul.os.proc_.finished._result.data._Msg0Nul4errX.TxtNul( Result(module,reference,git,timeout_milliseconds));
		}



		static public string MsgTrimmed(
			nilnul.fs.git.ModuleI module,
			nilnul.fs.git.repo._reference.Name reference
			,
			nilnul.win.prog_.Git git=null
			,
			int? timeout_milliseconds=null
		)
		{
			return  Msg(module,reference,git,timeout_milliseconds).Trim();
		}

		static public string MsgNulTrimmed(
			nilnul.fs.git.ModuleI module,
			nilnul.fs.git.repo._reference.Name reference
			,
			nilnul.win.prog_.Git git=null
			,
			int? timeout_milliseconds=null
		)
		{
			return  MsgNul(module,reference,git,timeout_milliseconds)?.Trim();
		}

		
	}
}
