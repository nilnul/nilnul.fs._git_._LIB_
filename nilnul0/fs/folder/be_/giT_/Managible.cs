using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.giT_
{
	/*
	 
	 */

	/// <summary>
	/// it's managed or would-be managed. so it is:
	///		plain
	///			or
	///		work
	///			or
	///		repo_.bare_.top
	///			(repo_.bare_.nontop is not manageable)
	///		(repo_.nonbare is not manageable)
	/// </summary>
	public class Manageable
		:
		nilnul.win.prog_.git.Boxed,

		nilnul.fs.folder.BeI
	{



		public Manageable(win.prog_.Git git) : base(git)
		{

		}
		public Manageable() : base(win.prog_.Git.StaticInstance)
		{

		}

		public bool be(FolderI folder)
		{
			return fs.folder.be_.git_.Plain0work.Singleton.be(folder) || fs.folder.be_.giT_.repo_.bare_._TopX.Be(folder);
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


		static public Manageable Ov(nilnul.win.prog_.Git git = null)
		{
			if (git is null)
			{
				return Singleton;
			}
			return new Manageable(git);
		}

		static public Manageable Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Manageable>.Instance;
			}
		}

	}
}
