using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module._work_.div.doc_
{
	static public class _IgnoreX
	{
		public const string NAME = ".gitignore";

		static public nilnul.fs._address.Doc Doc {
			get {
				return new _address.Doc(NAME);
			}
		}
		public static nilnul.fs.address_.SpearI Spear(nilnul.fs.FolderI folder)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(
				folder.address.en
				,
				NAME
			 );
		}

		public static bool Exist(nilnul.fs.FolderI folder) {
			return System.IO.File.Exists(
				Spear(folder).ToString()
			)
			;
		}
	}
}
