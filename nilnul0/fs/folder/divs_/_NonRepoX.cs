using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.divs_
{
	/// <summary>
	/// no:
	///		repo
	///		link
	/// </summary>
	static public class _NoRepoUnLinkX
	{
		static public IEnumerable<string> _Addresses(string _folder) {
			if (nilnul.fs.folder.be_.Normal.Singleton.be_ofAddress(_folder))
			{
				return nilnul.fs.folder_.nonlink.divs_._NoRepoUnLinkX._Addresses(_folder);
			}
			else
			{
				return new string[0];
			}

		}
	}
}
