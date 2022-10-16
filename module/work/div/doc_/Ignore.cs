using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div.doc_
{
	public class Ignore
	{
		public const string _DOC__TXT = ".gitignore";

		static public nilnul.fs._address.Doc Doc
		{
			get
			{
				return new _address.Doc(_DOC__TXT);
			}
		}

		public static nilnul.fs.address_.SpearI Spear(nilnul.fs.FolderI folder)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(
				folder.address.en
				,
				_DOC__TXT
			 );
		}

		public static nilnul.fs.address_.SpearI Spear_ofFolderAddress(string folder)
		{
			return Spear(
				nilnul.fs.Folder.FroAddress(folder)
			);
		}



	}
}
