using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.divs_
{

	///
	/// <summary>
	/// </summary>
	/// alias:
	///		nonlink ( not unlink ), meaning no dnt is link.
	///
	///		<see cref="nilnul.fs.git.depo._werk_.divs_.INonlink"/>
	/// 
	///	supersede:
	///		<see cref="nilnul.fs.folder_.giT_.work_.top.divs_.nonlink_._WithinWorkX"/>
	///		
	///	
	static public class _NonlinkX
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
				nilnul.fs.folder_.giT_.work_.top.directories_.nonlink_._NontopX._Infos_assumeModule(_module,git)
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

				directories_._NonlinkX.Addresses_ofAddress(_module,git)
			)
			{
				yield return directory;
			}
			yield return _module;
		}


	}
}
