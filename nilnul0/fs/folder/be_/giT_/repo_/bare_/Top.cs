﻿using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.giT_.repo_.bare_
{
	/*
	 git rev-parse --show-toplevel
		returns "" with exit code "0"
	for both repo_bare and repo_nonBare.
	 */
	static public class _TopX
	{
		static public bool Be(string address, Git git=null) {
			return nilnul.fs.folder.be_.giT_.repo_.Bare.Ov(git).be_ofAddress(address)
				&&
				nilnul.fs.folder_.giT_.repo.be_._TopX._Be_assumeRepoAddress(address,git);

		}

		public static bool Be(FolderI folder, Git git=null)
		{

			return Be(folder.ToString(),git);
		}
	}

	public class Top
	:
	nilnul.win.prog_.git.Boxed,

	nilnul.fs.folder.BeI
	{

		public Top(Git val) : base(val)
		{
		}
		public Top()
		{

		}

		public bool be(FolderI folder)
		{
			return fs.folder.be_.giT_.repo_.bare_._TopX.Be(folder,boxed)
				;
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


		static public Top Ov(nilnul.win.prog_.Git git = null)
		{
			if (git is null)
			{
				return Singleton;
			}
			return new Top(git);
		}

		static public Top Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Top>.Instance;
			}
		}

	}

}
