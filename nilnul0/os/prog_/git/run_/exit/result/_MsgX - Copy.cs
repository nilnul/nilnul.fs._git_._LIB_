using System;
using nilnul.fs.folder_.git_;
using nilnul.fs.folder_.git_.work_;
using nilnul.fs.git;

namespace nilnul.win.prog_.git.run.result
{
	/// <summary>
	/// throw err;timeout
	/// </summary>
	/// 
	//[Obsolete(nameof(git.run.result._MsgX))]
	public class _MsgX
	{
		public static string Msg(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return nilnul.os.proc_.finished._result.data._MsgX.Msg(nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(
				module
				,
				arg
				,
				git
			)
			);
		}
		private static string Msg(fs.folder_.git_.work_.Top top1, string arg, Git git)
		{
			return Msg((top1.en) ,arg,git);

		}

		[Obsolete()]
		public static string Msg(fs.folder_.git_.Top gitTop, string v, Git git=null)
		{
			return Msg((gitTop.en) ,v,git);
		}

		public static string Msg(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Msg((module.top1),arg,git);
			
		}


		public static string Msg(nilnul.fs.git.Module gitTop, string v, Git git=null)
		{
			return Msg((ModuleI)(gitTop) ,v,git);
		}




		public static string Msg(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Msg(new nilnul.fs.Folder(module),arg,git);
		}

		//public static string MsgTrimmed(
		//	nilnul.fs.address_.ShieldI module,
		//	string arg,
		//	nilnul.win.prog_.Git git = null
		//	)
		//{
		//	return Msg(
		//		module
		//		,
		//		arg
		//		,
		//		git

		//	).Trim();


		//}

		public static string OfAddress(
			string  module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Msg(
				nilnul.fs.address_.Shield.Parse(module)
				,
				arg
				,
				git

			);


		}

		
	}
}
