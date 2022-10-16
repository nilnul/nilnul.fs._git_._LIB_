using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_
{
	/// <summary>
	/// git_.work
	/// </summary>
	public class Plain0Nontop :nilnul.fs.folder.BeI
	{
		

		public bool be(FolderI obj)
		{
			return be_.git_.None.Singleton.be(obj)
				||
				be_.git_.work_.Nontop.Singleton.be(obj);
				
				;
			//throw new NotImplementedException();
		}
		public bool be(Folder obj)
		{
			return be((FolderI)obj);
				;
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

		public bool be(DirectoryInfo child)
		{
			return be(
				new nilnul.fs.Folder(
					
					child

				)
			);


		}

		static public Plain0Nontop Singleton
		{
			get
			{
				return nilnul.Singleton1<Plain0Nontop>.Instance;
			}
		}

	}
}
