using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module.work._ignore.div
{
	[Obsolete(nameof(git.module.work.div.doc_.Ignore))]
	static public class _DocX
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
				div._DocX.NAME
			 );
		}
	}
}
