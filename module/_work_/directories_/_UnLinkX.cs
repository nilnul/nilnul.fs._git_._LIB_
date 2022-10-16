using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directories_
{
	static public class _UnLinkX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var child in nilnul.fs.git.module._work_.dirs_._UnLinkX1._Addresses_addressAssumeModule(module))
			{
				foreach (var item in directory_.unLink.divs_._UnLinkX.Addresses_ofAddress(child))
				{
					yield return item;
				}
			}
		}
	}
}