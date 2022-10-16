using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlink_.giT_
{
	/// <summary>
	/// alias:
	///		plainChild.
	/// </summary>
	public class Nonrepo : nilnul.fs.folder_.Normal
	{

		public Nonrepo(FolderI val) : base(val)
		{
			nilnul.fs.folder.be_.git_.nonrepo.Vow.Singleton.vow(val);
		}

		public Nonrepo(ShieldI shield) : this( new nilnul.fs.Folder( shield) )
		{

		}

		static public Nonrepo OfAddress(string address) {
			return new Nonrepo(
				nilnul.fs.address_.Shield.FroAddress(address)
			);
		}

	}
}
