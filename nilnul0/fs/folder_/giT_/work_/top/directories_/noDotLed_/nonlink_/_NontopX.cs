using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.directories_.noDotLed_.nonlink_
{
	static public class _NontopX
	{

		static public IEnumerable<string> _Addresses_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			foreach (
				var child in dirs_.noDotLed_.nonlink_._NontopX._Addresses_addressAssumeModule(module)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_.noDotLed_.nonlink_._NontopX._Addresses_addressAssumeNontop(child)
				)
				{
					yield return item;
				}
			}
		}

		public static IEnumerable<DirectoryInfo> _Infos_assumeModule(DirectoryInfo _module)
		{
			foreach (
				var child in dirs_.noDotLed_.nonlink_._NontopX._Infos_assumeModule(_module)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_.noDotLed_.nonlink_._NontopX._Infos_assumeNontop(child)
				)
				{
					yield return item;
				}
			}

		}
	}
}