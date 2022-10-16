using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders.divs_.nonlink_.git_
{
	public class _NonRepoX
	{
		static public IEnumerable<string> _Addresses(IEnumerable<string> folders ) {

			return folders.SelectMany(
				x=> nilnul.fs.folder.divs_.nonlink_._NonRepoX._Addresses(x)
			);

		}

	}
}
