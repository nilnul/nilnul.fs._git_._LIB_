using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.normal_.git_.work_.nonTop.divs_
{
	[Obsolete("obscure; consider to move this to nilnul.fs.git.module.work.Divs")]
	static public class _NoRepoUnLinkX
	{
		static public IEnumerable<string> _Addresses(string _folder_normal_work_nontop) {
			foreach (var item in nilnul.fs.folder.dirs_._NonlinkX.Addresses_ofAddress(_folder_normal_work_nontop))
			{
				if (nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(item))
				{
					foreach (var item2 in nilnul.fs.folder_.normal_.git_.work_.top.divs_._NoRepoUnLinkX._Addresses(item))
					{
						yield return item2;
					}
				}
				else
				{
					foreach (var item3 in _Addresses(item))
					{
						yield return item3;
					}
				}
			}
			yield return _folder_normal_work_nontop;
		}
	}
}