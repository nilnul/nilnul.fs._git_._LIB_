using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.divs_.nonlink_
{

	/// <summary>
	/// </summary>
	static public class _NontopX
	{

		static public IEnumerable<string> _Addresses_addressAssumeNontop(
			string _nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var directory
				in

				directories_.nonlink_._NontopX._Infos_addressAssumeNontop(_nontop)
			)
			{
				yield return directory.FullName;
			}
			yield return _nontop;
		}

		static public IEnumerable<DirectoryInfo> _Infos_assumeNontop(
			DirectoryInfo _nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var directory
				in

				directories_.nonlink_._NontopX._Infos_assumeNontop(_nontop)
			)
			{
				yield return directory;
			}
			yield return _nontop;
		}

	}
}
