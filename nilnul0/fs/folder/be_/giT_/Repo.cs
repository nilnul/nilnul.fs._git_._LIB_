using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_
{
	/*
	  git rev-parse --is-inside-git-dir
		returns:
			"true", 0
				for repo, bare or nonbare.
			fatal, 128
				for plain folder
	 */

	public class Repo
		:
		nilnul.obj.Box1<win.prog_.Git>
		,
		nilnul.fs.folder.BeI
	{


		//public bool be(FolderI folder)
		//{


		//	return categorize_.git_.plainWorkRepo.io.be_.Repo.Singleton.be(
		//		categorize_.git_.plainWorkRepo.Io.Eval(folder)
		//	);


		//}

		public Repo(win.prog_.Git git):base(git)
		{

		}
		public Repo():base(win.prog_.Git.StaticInstance)
		{

		}

		public bool _be_assumeFolder(string folder)
		{
			return categorize_.git_.PlainWorkRepo._Trich_assumeFolder(folder,boxed) == categorize_.git_._plainWorkRepo.Ret.Repo
			;
		}

		public bool be(FolderI folder)
		{
			return categorize_.git_.plainWorkRepo.io.be_.Repo.Singleton.be(
				categorize_.git_.plainWorkRepo.Io.Eval(folder,boxed)
			);
		}

		public bool be(Folder obj)
		{
			return be((FolderI)obj);
			//throw new NotImplementedException();
		}
		public bool be(nilnul.fs.address_.ShieldI obj)
		{
			return be(new nilnul.fs.Folder(obj));
			//throw new NotImplementedException();
		}

		public bool be(DirectoryInfo obj)
		{
			return be(new nilnul.fs.Folder(obj));
			//throw new NotImplementedException();
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


		static public Repo Ov(nilnul.win.prog_.Git git = null)
		{
			if (git is null)
			{
				return Singleton;
			}
			return new Repo(git);
		}

		static public Repo Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Repo>.Instance;
			}
		}

	}
}
