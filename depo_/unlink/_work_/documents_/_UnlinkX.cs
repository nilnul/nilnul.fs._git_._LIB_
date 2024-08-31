using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_.documents_
{
	static public class _UnlinkX
	{
		static public IEnumerable<string> Addresses( module_.Unlink module) {
			foreach (var div in divs_.UnLinkX.OfAddress(module))
			{
				foreach (var doc in div_.unlink.docs_._UnlinkX.Addresses_ofAddress(div))
				{
					yield return doc;

				}
			}
		}

		static public IEnumerable<string> Addresses_ofAddress(string module)
		{
			return Addresses( nilnul.fs.git.module_.Unlink.FroAddress(module));
		}

		static public IEnumerable<FileInfo> Infos_ofAddress(string module)
		{
			return Addresses_ofAddress(module).Select(x=>new FileInfo(x));
		}




	}
}
