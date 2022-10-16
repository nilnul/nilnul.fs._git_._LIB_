using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_
{
	static public class _NoneX
	{
		static public bool Be(FolderI folder, nilnul.win.prog_.Git git=null)
		{
			return categorize_.git_.plainWorkRepo.io.be_.None.Singleton.be(
						categorize_.git_.plainWorkRepo.Io.Eval(folder,git)
			);
		}
		static public bool Be_ofShield(string spear, nilnul.win.prog_.Git git = null) {
			return Be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.Shield.Parse(
					spear
					)

				),git
			);
		}

		static public bool Be_ofAddress(string spear, nilnul.win.prog_.Git git = null) {
			return Be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.shield_._AddressX1.Create(
					spear
					)

				),git
			);
		}

	}

	public class None
		: nilnul.fs.folder.BeI
	{
		public bool be(FolderI folder)
		{
			return categorize_.git_.plainWorkRepo.io.be_.None.Singleton.be(
						categorize_.git_.plainWorkRepo.Io.Eval(folder)
			);
		}

	



		public bool be_ofShield(string spear) {
			return be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.Shield.Parse(
					spear
					)

				)
			);
		}

		public bool be_ofAddress(string spear) {
			return be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.shield_._AddressX1.Create(
					spear
					)

				)
			);
		}



		static public None Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<None>.Instance;
			}
		}

	}
}
