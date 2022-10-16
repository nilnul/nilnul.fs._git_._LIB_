using nilnul.fs;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;

namespace nilnul.win.prog_.git.run.result.msgOrNul4err
{
	public class _TrimmedX
	{

		public static string Txt(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return _MsgOrNul4errX.Msg(
				module
				,
				arg
				,
				git

			)?.Trim();


		}
		public static string Txt(Exist address, string v, prog_.Git git=null)
		{
			return Txt(address.en, v, git);
		}
		public static string Txt(FolderI en, string v, prog_.Git git=null)
		{
			return Txt(en.address, v, git);
		}
		public static string Txt(Folder en, string v, prog_.Git git=null)
		{
			return Txt((FolderI)en, v, git);
		}


		public static string Txt(Top top, string v, nilnul.win.prog_.Git git=null)
		{
			return Txt(top.en, v, git);
		}


		public static string Txt(ModuleI module, string v, nilnul.win.prog_.Git git=null)
		{
			return Txt(module.top, v, git);
		}
		public static string Txt(fs.git.Module module, string v, nilnul.win.prog_.Git git=null)
		{
			return Txt((ModuleI)module, v, git);
		}

		public static string OfAddress(
			string module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			return Txt(
				nilnul.fs.address_.Shield.Parse(module)
				,
				arg
				,
				git

			);


		}

	}
}
