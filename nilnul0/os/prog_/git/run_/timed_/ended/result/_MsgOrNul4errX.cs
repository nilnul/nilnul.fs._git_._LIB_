using System;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;

namespace nilnul.win.prog_.git.run.result
{
	/// <summary>
	/// throw err
	/// </summary>
	public class _MsgOrNul4errX
	{
		public static string Msg(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return nilnul.os.prog_.git.run_.ended._ResultX.Result(
				module
				,
				arg
				,
				git
			).msgOrNul4err;
		}
		public static string Msg(nilnul.fs.git.Module gitTop, string v, Git git=null)
		{
			return Msg((ModuleI)(gitTop) ,v,git);
		}


		public static string Msg(Top gitTop, string v, Git git=null)
		{
			return Msg(new nilnul.fs.git.Module(gitTop) ,v,git);
		}

		public static string Msg(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Msg(new Top(module),arg,git);
		}

		public static string Msg(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Msg(new nilnul.fs.Folder(module),arg,git);
		}

		public static string MsgTrimmed(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Msg(
				module
				,
				arg
				,
				git

			).Trim();


		}

		public static string OfAddress(
			string  module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return MsgTrimmed(
				nilnul.fs.address_.Shield.Parse(module)
				,
				arg
				,
				git

			);


		}

		
	}
}
