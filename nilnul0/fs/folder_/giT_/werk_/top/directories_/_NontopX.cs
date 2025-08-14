using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.directories_
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
				var child in dirs_._NontopX._Addresses_assumeModuleAddress(module)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_._NontopX._Addresses_addressAssumeNontop(child)
				)
				{
					yield return item;
				}
			}
		}

		public static IEnumerable<DirectoryInfo> _Infos_assumeModule(DirectoryInfo module)
		{
			foreach (
				var child in dirs_._NontopX._Infos_assumeModule(module)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_._NontopX._Infos_assumeNontop(child)
				)
				{
					yield return item;
				}
			}


		}
	}
}