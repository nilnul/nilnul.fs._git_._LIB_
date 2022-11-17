using System;
using nilnul.fs.folder_.git_;
using nilnul.fs.folder_.git_.work_;
using nilnul.fs.git;

namespace nilnul.win.prog_.git.run_.timeout.result
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
			return nilnul.win.prog._run.result._MsgX.Msg(
				nilnul.os.prog_.git.run_.timed_.ended._ResultX.Result(
					module
					,
					arg
					,
					git
					, life
				)
			);
		}
		private static string Msg(fs.folder_.git_.work_.Top top1, string arg, Git git,
			int? life = null
)
		{
			return Msg(
				(top1.en), arg, git, life
			);

		}

		[Obsolete()]
		public static string Msg(fs.folder_.git_.Top gitTop, string v, Git git = null
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
