using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.directories_.nonlink_
{
	/// <summary>
	/// work_.nontop
	/// </summary>
	///
	[Obsolete(nameof(fs.git.depo._werk_.directories_._NonlinkX) + " is preferred in that it's more succinct and less ambiguous.")]
	static public class _NontopX
	{


		static public IEnumerable<string> _Addresses_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			foreach (
				var child in dirs_.nonlink_._NontopX._Addresses_addressAssumeModule(module)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_.nonlink_._NontopX._Addresses_addressAssumeNontop(child)
				)
				{
					yield return item;
				}
			}
		}

		public static IEnumerable<DirectoryInfo> _Infos_assumeModule(DirectoryInfo module
						,
			nilnul.win.prog_.Git git = null

		)
		{
			foreach (
				var child in dirs_.nonlink_._NontopX._Infos_assumeModule(module,git)
			)
			{
				foreach (
					var item in

					work_.nontop.divs_.nonlink_._NontopX._Infos_assumeNontop(child,git)
				)
				{
					yield return item;
				}
			}

		}
	}
}