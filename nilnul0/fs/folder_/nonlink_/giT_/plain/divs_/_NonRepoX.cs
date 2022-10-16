using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.normal_.git_.plain.divs_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _NoRepoUnlinkX
	{
		static public IEnumerable<string> _Addresses(string _folder_normal_plain) {

			foreach (var item in nilnul.fs.folder.dirs_._NonlinkX.Addresses_ofAddress(_folder_normal_plain))
			{
				if (nilnul.fs.folder.be_.git_.Work.Singleton.be_ofAddress(item))
				{//top

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
			yield return _folder_normal_plain;

			


			
		}
	}
}
