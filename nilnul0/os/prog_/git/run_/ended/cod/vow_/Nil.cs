using System;
using nilnul.fs;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;

namespace nilnul.win.prog_.git.run.cod.vow_
{
	//[Obsolete(nameof(prog_.git.run.result._Void_throwErrX))]   Note: exitCode can be got simpler than result as the latter requires async, Noshell(or shell?)
	public class _NilX
	{

		public static void _Vod_ofAddress_ofArgs(string module, params string[] args)
		{
			 nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
				run._CodX._ExitCode_ofAddress(module, args)
			);


		}

		public static void _Vod_ofAddress_ofArg(string module,  string args, nilnul.win.prog_.Git git=null)
		{
			 nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
				run._CodX._ExitCode_ofAddress(module, args,git)
			);


		}


		public static void Void(
			nilnul.fs.address_.ShieldI module,
			string arg,
			string xpn
			,
			nilnul.win.prog_.Git git = null
		)
		{
			new nilnul.num.integer_.int32.be_.nil.Vow(xpn).vow(
				run._CodX._ExitCode(module, arg, git)
			);
		}

		public static void Void(ModuleI module
			,
			string v1
			,
			string v2
			,
			nilnul.win.prog_.Git git = null

		)
		{
			Void(
				module.top1.en.address.en,v1,v2
				,git
			);
		}

		public static void Void(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
				run._CodX._ExitCode(module, arg, git)
			);
		}

		public static void Void(FolderI en, string v, Git git=null)
		{
			Void(en.address.en,v,git);
		}

		public static void Void(
			Top module
			, string v
			,
			nilnul.win.prog_.Git git = null
			)
		{
			Void(module.en, v, git);
		}

		public static void Void(
			fs.folder_.git_.work_.Top module
			, string v
			,
			nilnul.win.prog_.Git git = null
			)
		{
			Void(module.en, v, git);
		}

		public static void OfAddress(
			string  module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			 Void(
				nilnul.fs.address_.Shield.FroAddress(module)
				,
				arg
				,
				git

			);


		}

		

		public static void Void(ModuleI folder, string v, Git git=null)
		{
			 Void(folder.top,v,git);
		}

		public static void OfAddress(
			string  module,
			string arg,
			string xpn
			,
			nilnul.win.prog_.Git git = null
			)
		{
			 Void(
				nilnul.fs.address_.Shield.Parse(module)
				,
				arg
				,xpn
				,
				git

			);


		}

	}
}
