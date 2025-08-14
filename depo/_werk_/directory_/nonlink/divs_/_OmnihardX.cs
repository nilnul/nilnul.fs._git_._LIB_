using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.directory_.nonlink.divs_
{
	/// <summary>
	/// not repo;
	/// not submodule;
	/// within the same werk.
	/// </summary>
	/// <see cref="nilnul.fs.folder_.giT_.work_.nontop.divs_._NontopX"/>
	/// <see cref="nilnul.fs.folder_.giT_.work_.nontop.divs_.nonlink_._NontopX"/>
	///
	[Obsolete(nameof(nilnul.fs.folder_.giT_.work_.nontop.divs_.nonlink_._NontopX) + " is preferred")]
	static public class _OmnihardX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectoryUnlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var directory in directories_._OmnihardX.Addresses_ofAddress(workDirectoryUnlink))
			{
				yield return directory;
			}
			yield return workDirectoryUnlink;
		}
	}
}
