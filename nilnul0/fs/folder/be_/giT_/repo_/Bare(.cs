using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.giT_.repo_
{
	public class Bare
		:
		nilnul.win.prog_.git.Boxed,

		nilnul.fs.folder.BeI
	{

		public Bare(Git val) : base(val)
		{
		}
		public Bare()
		{

		}

		public bool be(FolderI folder)
		{
			return fs.folder.be_.git_. Repo.Ov(boxed).be(folder)
				&&
				nilnul.fs.folder_.git_.repo.be_._BareX._Be_assumeRepo(folder,boxed);
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


		static public Bare Ov(nilnul.win.prog_.Git git = null)
		{
			if (git is null)
			{
				return Singleton;
			}
			return new Bare(git);
		}

		static public Bare Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Bare>.Instance;
			}
		}

	}
}
