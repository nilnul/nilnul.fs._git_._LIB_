using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_.divs_
{
	static public class UnLinkX
	{
		static public IEnumerable<string> _Addresses_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			foreach (var child in dirs_._UnLinkX.Addresses_ofAddress(module))
			{
				foreach (var item in directory_.unLink.divs_._UnLinkX.Addresses_ofAddress(child))
				{
					yield return item;
				}
			}
			yield return module;

		}

		public static IEnumerable<string> OfAddress(Unlink module)
		{
			return _Addresses_ofAddress(module.en.top.en.ToString());
			//throw new NotImplementedException();
		}
	}
}
