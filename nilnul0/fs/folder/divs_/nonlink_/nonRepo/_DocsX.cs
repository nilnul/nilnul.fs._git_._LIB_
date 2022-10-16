using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.divs_.nonlink_.nonRepo
{
	static public class _DocxX
	{
		static public IEnumerable<string> _Docs(string _folder)
		{

			return _NonRepoX._Addresses(_folder).SelectMany(
				x=> nilnul.fs.folder._DocsX.Docs_ofAddress(x)
			);

		}


		static public IEnumerable<address_.spear_.ParentDoc> _ParentDocS(string _folder)
		{

			return _Docs(_folder).Select(
				x=>
				new nilnul.fs.address_.spear_.ParentDoc(_folder,x)
			);

		}

	}
}
