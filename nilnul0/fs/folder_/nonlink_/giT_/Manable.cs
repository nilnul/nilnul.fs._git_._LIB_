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
	public class Manable : nilnul.fs.folder_.Normal
	{

		public Manable(FolderI val) : base(val)
		{
			nilnul.fs.folder.be_.giT_.manable.Vow.Singleton.vow(val);
		}

		public Manable(ShieldI shield) : this( new nilnul.fs.Folder( shield) )
		{

		}

		static public Manable OfAddress(string address) {
			return new Manable(
				nilnul.fs.address_.Shield.FroAddress(address)
			);
		}

	}
}
