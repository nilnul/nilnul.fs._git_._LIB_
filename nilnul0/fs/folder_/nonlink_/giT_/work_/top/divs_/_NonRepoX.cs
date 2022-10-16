using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.normal_.git_.work_.top.divs_
{
	[Obsolete("obscure; consider to move this to nilnul.fs.git.module.work.Divs")]

	static public class _NoRepoUnLinkX
	{
		static public IEnumerable<string> _Addresses(string _folder_normal_work_top) {

			foreach (var item in nilnul.fs.folder.dirs_._NonlinkX.Addresses_ofAddress(_folder_normal_work_top))
			{
				if (nilnul.fs.folder.be_.git_.Work.Singleton.be_ofAddress(item))
				{
					foreach (var item2 in nilnul.fs.folder_.normal_.git_.work.divs_._NoRepoUnLinkX._Addresses(item))
					{
						yield return item2;
					}
				}
				//else repo
			}
			yield return _folder_normal_work_top;
			
		}
	}
}
