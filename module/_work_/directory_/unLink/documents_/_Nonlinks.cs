using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory_.nonlink.documents_
{
	static public class _NonlinkX
	{
		private static IEnumerable<string> _OfNontopWork(string nontopWork)
		{
			foreach (
				var child in nilnul.fs.folder.dirs_._NonlinkX.Addresses_ofAddress(
				nontopWork
				)
				)
			{
				if (!nilnul.fs.folder_.git_.work.be_._TopX._Be(child))
				{
					///sub


					foreach (var item in _OfNontopWork(child))
					{
						yield return item;
					}

				}

			}
			foreach (var item in nilnul.fs.folder.docs_._NormalX._AddressTxts_ofFolderAddress(nontopWork))
			{
				yield return item;

			}

		}


	}
}
