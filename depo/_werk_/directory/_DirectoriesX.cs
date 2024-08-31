using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// </summary>
	/// <see cref="fs.folder_.giT_.work_.nontop.directories_._NontopX"/>
	static public class _DirectoriesX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectory
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return fs.folder_.giT_.work_.nontop.directories_._NontopX._Addresses_addressAssumeNontop(workDirectory,git);

			//foreach (var child in _DirsX.Addresses_ofAddress(workDirectory))
			//{
			//	foreach (var item in _DivsX.Addresses_ofAddress(child))
			//	{
			//		yield return item;
			//	}
			//}
		}
	}
}
