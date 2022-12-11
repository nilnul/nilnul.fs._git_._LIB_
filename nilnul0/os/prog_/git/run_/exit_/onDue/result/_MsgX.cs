using System;
using nilnul.fs.folder_.git_;
using nilnul.fs.folder_.git_.work_;
using nilnul.fs.git;
using nilnul.win.prog_;

namespace nilnul.os.prog_.git.run_.exit_.onDue.result
{
	/// <summary>
	/// throw err;timeout
	/// </summary>
	public class _MsgX
	{
		public static string Msg(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.win.prog_.Git git = null

			,
			int? life = null

			)
		{
			return nilnul.os.proc_.finished._result.data._MsgX.Msg(
				nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(
					module
					,
					arg
					,
					git
					, life
				)
			);
		}
		private static string Msg(nilnul.fs.folder_.git_.work_.Top top1, string arg, Git git,
			int? life = null
)
		{
			return Msg(
				(top1.en), arg, git, life
			);

		}

		[Obsolete()]
		public static string Msg(nilnul.fs.folder_.git_.Top gitTop, string v, Git git = null
			,
			int? life = null
)
		{
			return Msg(
				(gitTop.en), v, git, life
			);
		}

		public static string Msg(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			,
			int? life = null
		)
		{
			return Msg((module.top1), arg, git, life);

		}


		public static string Msg(nilnul.fs.git.Module gitTop, string v, Git git = null,
			int? life = null
)
		{
			return Msg((ModuleI)(gitTop), v, git, life);
		}

		public static string Msg(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			,
			int? life = null
		)
		{
			return Msg(new nilnul.fs.Folder(module), arg, git, life);
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
			string module,
			string arg,
			nilnul.win.prog_.Git git = null
			,
			int? life = null
		)
		{
			return Msg(
				nilnul.fs.address_.Shield.Parse(module)
				,
				arg
				,
				git
				, life
			);
		}
	}
}
