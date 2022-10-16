using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.normal_.git_.work_.nonTop.documents_.git_
{

	static public class _NonRepoX
	{
		static public IEnumerable<string> _Addresses(string _folder_normal_work_top) {
			foreach (var item in nilnul.fs.folder.dirs_._NormalX.Enumerate(_folder_normal_work_top))
			{
				if (nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(item))
				{

					foreach (var item2 in nilnul.fs.folder_.normal_.git_.work_.top.documents_.git_._NonRepoX._Addresses(item))
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

			foreach (var item in nilnul.fs.folder.docs_._NormalX.EnumerateAsAddress(_folder_normal_work_top))
			{
				yield return item;

			}

			
		}
	}
}
