using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.divs_.noDotLed_.nonlink_
{

	/// <summary>
	///  each segment is unclave, unlink, non<see cref="fs.folder.be_.giT_.managed_._TopX"/>(bare repo, or inner depo)
	/// </summary>
	static public class _NontopX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="workDirectoryUnlink">
		/// <see cref="fs.folder.be_.git_.work_.Nontop"/>
		/// </param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<DirectoryInfo> _Infos_assumeNontop(
			DirectoryInfo workDirectoryUnlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var directory
				in

				directories_.noDotLed_.nonlink_._NontopX._Infos_assumeNontop(workDirectoryUnlink)
			)
			{
				yield return directory;
			}
			yield return workDirectoryUnlink;
		}

		static public IEnumerable<string> _Addresses_addressAssumeNontop(
			string workDirectoryUnlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var directory
				in

				directories_.noDotLed_.nonlink_._NontopX._Infos_addressAssumeNontop(workDirectoryUnlink)
			)
			{
				yield return directory.FullName;
			}
			yield return workDirectoryUnlink;
		}

	}


}
