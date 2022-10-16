using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.divs_.noDotLed_
{

	/// <summary>
	/// </summary>
	static public class _WithinWorkX
	{

		static public IEnumerable<DirectoryInfo> _Infos_assumeTop(
			DirectoryInfo _module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var directory
				in

				directories_.noDotLed_._NontopX._Infos_assumeTop(_module,git)
			)
			{
				yield return directory;
			}
			yield return _module;
		}

		static public IEnumerable<string> _Addresses_addressAssumeTop(
			string _module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var directory
				in

				directories_.noDotLed_._NontopX._Addresses_addressAssumeTop(_module,git)
			)
			{
				yield return directory;
			}
			yield return _module;
		}


	}
}
