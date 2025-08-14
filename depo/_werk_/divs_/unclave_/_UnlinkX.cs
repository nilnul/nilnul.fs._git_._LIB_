using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.divs_.unclave_
{
	/// <summary>
	/// the base folder, then each nonlink unclave dir.
	/// </summary>

	static public class _UnlinkX
	{

		static public IEnumerable<string> _Addresses_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return ((string[])[module]).Concat(
				nilnul.fs.git.module._work_.directories_.notDotLed_._NonlinkX._Addresses_addressAssumeModule(module,git)
				);

			

		}
	}
}