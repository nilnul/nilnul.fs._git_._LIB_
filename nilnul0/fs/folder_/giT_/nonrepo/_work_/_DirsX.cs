using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.nonrepo._work_
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// </summary>
	static public class _DirsX
	{

		static public IEnumerable<string> Addresses_addressAssumeNonrepo(
			string nonrepo
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var child in Directory.EnumerateDirectories(nonrepo))
			{
				if (nilnul.fs.folder.be_.git_.Plain0Nontop.Singleton.be_ofAddress(child))
				{

					yield return child;


				}


			}
		}

		static public IEnumerable<DirectoryInfo> _Infos_addressAssumeNonrepo(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var dirInfo = new DirectoryInfo(module);
			foreach (var child in dirInfo.EnumerateDirectories())
			{
				if (nilnul.fs.folder.be_.git_.Plain0Nontop.Singleton.be(child))
				{

					yield return child;


				}
			}
		}

	}
}
