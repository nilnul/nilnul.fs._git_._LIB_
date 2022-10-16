using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder;

namespace nilnul.fs.address.be_.giT_
{
	public class FolderNonrepo : 
		nilnul.fs.address.BeI
	{
		public bool be(AddressI obj)
		{
			return nilnul.fs.address.be_.Folder.Singleton.be(obj)

				&&

				nilnul.fs.folder.be_.git_.repo.Anto.Singleton.Be(obj)
			;
		}

		static public FolderNonrepo Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<FolderNonrepo>.Instance;
			}
		}

	}
}
