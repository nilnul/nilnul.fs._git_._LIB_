using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.folder.doc_.git_.ignore
{
	static public class _EnforceX
	{
		static public void Make(nilnul.fs.FolderI targetAddress, string blob)
		{
			nilnul.fs.file_.git_.ignore._EnforceX.Make(
				_IgnoreX.Spear(targetAddress),blob
			);
		}
		static public void Make(nilnul.fs.address_.ShieldI targetAddress, string blob)
		{
			Make( new nilnul.fs.Folder(targetAddress),blob);
		}

		static public void Make(nilnul.fs.FolderI targetAddress, IEnumerable<string> blob)
		{
			nilnul.fs.file_.git_.ignore._EnforceX.Make(
				_IgnoreX.Spear(targetAddress),blob
			);
		}
		static public void Make(nilnul.fs.address_.ShieldI targetAddress, IEnumerable<string> blob)
		{
			Make( new nilnul.fs.Folder(targetAddress),blob);
		}

		static public void Make(string targetAddress,string blob)
		{
			Make(  nilnul.fs.address_.Shield.FroAddress(targetAddress) ,blob);
		}

		static public void Make(string targetAddress,IEnumerable<string> blob)
		{
			Make(  nilnul.fs.address_.Shield.FroAddress(targetAddress) ,blob);
		}


	}
}