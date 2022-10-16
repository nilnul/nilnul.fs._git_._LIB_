using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders.divs_.nonlink_.git_.nonRepo
{
	static class Docs
	{
		static public IEnumerable<string> _Docs(IEnumerable<string> folders)
		{
			return folders.SelectMany(
				x => nilnul.fs.folder.divs_.nonlink_.nonRepo._DocxX._Docs(x)
			);

		}

		static public IEnumerable<address_.spear_.ParentDoc> _ParentDocS(IEnumerable<string> folders)
		{

			return folders.SelectMany(
				x => nilnul.fs.folder.divs_.nonlink_.nonRepo._DocxX._ParentDocS(x)
			);

		}

	}
}
