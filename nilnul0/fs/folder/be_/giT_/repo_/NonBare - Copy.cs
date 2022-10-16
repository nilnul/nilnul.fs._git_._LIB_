using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_.repo
{
	public class NonBare
		: nilnul.fs.folder.BeI
	{



		public bool be(FolderI folder)
		{
			return Repo.Singleton.be(folder) && nilnul.fs.folder_.git_.repo.be_.bare._AntoX._Be(folder);
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




		static public NonBare Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NonBare>.Instance;
			}
		}

	}
}
