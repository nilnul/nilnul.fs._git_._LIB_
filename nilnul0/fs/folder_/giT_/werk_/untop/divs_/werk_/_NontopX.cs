using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.divs_
{

	/// <summary>
	/// werk but untop; <see cref="nilnul.fs.folder.be_.giT_.werk_.IInward"/>
	/// </summary>
	/// <remarks>
	/// exclude:
	///		repo
	///		subdepo
	/// </remarks>
	/// <see cref="nilnul.fs.git.depo._werk_.directory_.nonlink.divs_._OmnihardX"/>
	/// 
	/// alias:
	///		inward
	///		
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

				directories_._NontopX._Infos_addressAssumeNontop(_nontop)
			)
			{
				yield return directory.FullName;
			}
			yield return _nontop;
		}

		static public IEnumerable<DirectoryInfo> _Infos_assumeNontop(
			DirectoryInfo workDirectoryUnlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var directory
				in

				directories_.nonlink_._NontopX._Infos_assumeNontop(workDirectoryUnlink)
			)
			{
				yield return directory;
			}
			yield return workDirectoryUnlink;
		}

	}
}
