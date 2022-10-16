using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_
{
	static public class _WorkX
	{
		static public bool Be(FolderI obj, nilnul.win.prog_.Git git=null) {
			return categorize_.git_.plainWorkRepo.io.be_.Work.Singleton.be(
				categorize_.git_.plainWorkRepo.Io.Eval(obj,git)
				
			);
		}

		static public bool Be_ofShield(string spear, nilnul.win.prog_.Git git = null)
		{
			return Be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.Shield.Parse(
					spear
					)

				), git
			);
		}

		static public bool Be_ofAddress(string spear, nilnul.win.prog_.Git git = null)
		{
			return Be(
				new nilnul.fs.Folder(
					 nilnul.fs.address_.shield_._AddressX1.Create(
					spear
					)

				), git
			);
		}


	}
	/// <summary>
	/// git_.work
	/// </summary>
	public class Work : 
		nilnul.obj.Box<nilnul.win.prog_.Git>
		,
		nilnul.fs.folder.BeI
	{
		//public bool be(FolderI obj)
		//{
		//	return categorize_.git_.plainWorkRepo.io.be_.Work.Singleton.be(
		//		categorize_.git_.plainWorkRepo.Io.Eval(obj)
		//	);
		//	//throw new NotImplementedException();
		//}

		public Work(nilnul.win.prog_.Git git):base(git)
		{

		}
		public Work():this(nilnul.win.prog_.Git.StaticInstance)
		{

		}

		public bool be(FolderI obj)
		{
			return categorize_.git_.plainWorkRepo.io.be_.Work.Singleton.be(
				categorize_.git_.plainWorkRepo.Io.Eval(obj,boxed)
			);
			//throw new NotImplementedException();
		}

		[Obsolete("shall be Static ")]
		public bool be(FolderI obj, Git git)
		{
			return categorize_.git_.plainWorkRepo.io.be_.Work.Singleton.be(
				categorize_.git_.plainWorkRepo.Io.Eval(obj,git)
				
			);
			//throw new NotImplementedException();
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


		static public Work Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Work>.Instance;
			}
		}



	}
}
