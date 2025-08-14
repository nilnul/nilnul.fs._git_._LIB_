using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace nilnul.fs.git.module._work_.dirs_.noDotLed_.nonlink_
namespace nilnul.fs.folder_.giT_.work_.top.dirs_.noDotLed_.nonlink_
{
	/// <summary>
	/// </summary>
	///
	static public class _NontopX
	{
		static public IEnumerable<DirectoryInfo> _Infos_assumeModule(
				DirectoryInfo module
				,
				nilnul.win.prog_.Git git = null
			)
		{

			foreach (
				var child in fs.folder.dirs_.notDotLed_._NonlinkX.Infos(
					module
				)
			)
			{
				if (nilnul.fs.git.module.dir.be_._WorkX._Be_assumeModuleDir(child, git))
				{
					if (
						nilnul.fs.git.module.dir_.work.be_._NonTopX._BeNonTop_moduleDirAssumeWork(child, git)
					)
					{
						yield return child;

					}
				}
			}

		}
		static public IEnumerable<string> _Addresses_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			foreach (
				var child in fs.folder.dirs_.notDotLed_._NonlinkX.Addresses_ofAddress(
					module
				)
			)
			{
				if (nilnul.fs.git.module.dir.be_._WorkX._Be_ofAddress(child, git))
				{
					if (
						nilnul.fs.git.module.dir_.work.be_._NonTopX._Be(child, git)
					)
					{
						yield return child;

					}
				}
			}

		}
	}
}