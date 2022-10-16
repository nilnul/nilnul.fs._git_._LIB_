using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.documents_
{

	/// <summary>
	/// no:
	///		repo
	///		link
	/// </summary>
	static public class _NoRepoUnLinkX
	{
		static public IEnumerable<string> _Addresses(string _folder_normal) {

			foreach (var addressOfFolder in nilnul.fs.folder.divs_._NoRepoUnLinkX._Addresses(_folder_normal))
			{
				foreach (var file in nilnul.fs.folder.docs_._NormalX._AddressTxts_ofFolderAddress(addressOfFolder))
				{
					yield return file;
				}
			}
		}
	}
}
