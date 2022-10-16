using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_
{
	static public class _DirectoriesX
	{
	

		static public IEnumerable<string> Addresses_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			foreach (var child in nilnul.fs.git.module_.unlink._work_._DirsX.Addresses_ofAddress(module))
			{
				foreach (var item in directory._DivsX.Addresses_ofAddress(child))
				{
					yield return item;
				}
				yield return child;
			}
			
		}

		

	}
}
