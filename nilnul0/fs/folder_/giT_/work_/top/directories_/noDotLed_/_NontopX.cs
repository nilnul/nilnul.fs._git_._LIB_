using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.directories_.noDotLed_
{
	static public class _NontopX
	{

		static public IEnumerable<string> _Addresses_addressAssumeTop(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			foreach (
				var child in dirs_.noDotLed_._NontopX._Addresses_addressAssumeModule(module)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_.noDotLed_._NontopX._Addresses_addressAssumeNontop(child)
				)
				{
					yield return item;
				}
			}
		}
		static public IEnumerable<DirectoryInfo> _Infos_assumeTop(
			DirectoryInfo module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			foreach (
				var child in dirs_.noDotLed_._NontopX._Infos_assumeModule(module,git)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_.noDotLed_._NontopX._Infos_assumeNontop(child,git)
				)
				{
					yield return item;
				}
			}
		}

	}
}