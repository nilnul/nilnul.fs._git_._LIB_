using System;
using nilnul.fs;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;

namespace nilnul.win.prog_.git.run_.lurk.cod.vow_
{
	public class _NilX
	{


		public static void Void(
			nilnul.fs.address_.ShieldI module,
			string arg,
			string xpn,
			nilnul.win.prog_.Git git = null
		)
		{
			new nilnul.num.integer_.int32.be_.nil.Vow(xpn).vow(
				_CodX._ExitCode(module, arg, git)
			);
		}

		public static void Void(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
				_CodX._ExitCode(module, arg, git)
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
