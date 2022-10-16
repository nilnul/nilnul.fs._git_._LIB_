using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_
{
	static public class _Repo0WorkX
	{

		//static public bool Be(FolderI folder)
		//{
		//	return categorize_.git_.plainWorkRepo.io.be_.Module.Singleton.be(
		//		categorize_.git_.plainWorkRepo.Io.Eval(folder)
		//	);
		//}

		static public bool Be(FolderI folder)
		{
			return categorize_.git_.plainWorkRepo.io.be_.Nonplain.Singleton.be(
				categorize_.git_.plainWorkRepo.Io.Eval(folder)
			);
		}

		static public bool Be_ofAddress(string address) {
			return Be( nilnul.fs.Folder.FroAddress(address));
		}

	}
	public class Repo0Work
		: nilnul.fs.folder.BeI
	{

	

		public bool be(FolderI folder)
		{
			return _Repo0WorkX.Be(folder);
		}

		public bool be_ofShield(string spear)
		{
			return be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.Shield.Parse(
					spear
					)

				)
			);
		}

		public bool be_ofAddress(string spear)
		{
			return be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.shield_._AddressX1.Create(
					spear
					)

				)
			);
		}


		static public Repo0Work Singleton
		{
			get
			{
				return nilnul.Singleton1<Repo0Work>.Instance;
			}
		}

	}
}
