using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlink_.giT_
{
	/// <summary>
	/// </summary>
	public class Plain : nilnul.fs.folder_.Normal
	{

		public Plain(FolderI val) : base(val)
		{
			nilnul.fs.folder.be_.git_.none.Vow1.Singleton.vow(val);
		}

		public Plain(ShieldI shield) : this( new nilnul.fs.Folder( shield) )
		{

		}

		static public Plain OfAddress(string address) {
			return new Plain(
				nilnul.fs.address_.Shield.FroAddress(address)
			);
		}

	}
}
