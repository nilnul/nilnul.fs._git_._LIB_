using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.folder.doc_.git_.ignore.make
{
	static public class _CreateX
	{

		public static void Create(nilnul.fs.FolderI element, string blob)
		{
			nilnul.fs.file_.git_.ignore.make._CreateX.Create(
				_IgnoreX.Spear(element),blob
			);
			

		}

		public static void Create(nilnul.fs.FolderI element, IEnumerable<string> blob)
		{
			nilnul.fs.file_.git_.ignore.make._CreateX.Create(
				_IgnoreX.Spear(element),blob
			);
			

		}



		static public void Create(string targetAddress,string blob)
		{
			Create(
				nilnul.fs.Folder.FroAddress(targetAddress),blob
			);
		}

		static public void Create(string targetAddress,IEnumerable<string> blob)
		{
			Create(
				nilnul.fs.Folder.FroAddress(targetAddress),blob
			);
		}

	}
}