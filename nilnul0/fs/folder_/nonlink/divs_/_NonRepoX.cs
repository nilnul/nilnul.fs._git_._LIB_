using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlink.divs_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _NoRepoUnLinkX
	{
		static public IEnumerable<string> _Addresses(string _folder_normal) {

			var category = nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(_folder_normal);
			switch (category)
			{
				case folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					return nilnul.fs.folder_.normal_.git_.plain.divs_._NoRepoUnlinkX._Addresses(_folder_normal);
					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Work:
					return nilnul.fs.folder_.normal_.git_.work.divs_._NoRepoUnLinkX._Addresses(_folder_normal);

					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					return new string[0];

					break;
				default:
					throw new UnexpectedReachException();
					break;

			}

			
		}
	}
}
