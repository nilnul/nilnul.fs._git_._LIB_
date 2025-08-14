using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.dirs_
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// </summary>
	/// <see cref="fs.git.module._work_._DirsX"/>
	static public class _NontopX
	{

		static public IEnumerable<string> _Addresses_assumeModuleAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var child in Directory.EnumerateDirectories(module))
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

		public static IEnumerable<DirectoryInfo> _Infos_assumeModule(
			DirectoryInfo module,
			nilnul.win.prog_.Git git = null)
		{
			
			foreach (var child in module.EnumerateDirectories())
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

		[Obsolete(nameof(_Addresses_assumeModuleAddress))]
		static public IEnumerable<string> Addresses_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Addresses_assumeModuleAddress(module,git);
		}

		static public IEnumerable<DirectoryInfo> _DirInfoEs_moduleAssumeAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Infos_assumeModule(
				new DirectoryInfo(module)
				,
				git
			);

			//var dirInfo = new DirectoryInfo(module);


			//foreach (var child in dirInfo.EnumerateDirectories())
			//{
			//	if (nilnul.fs.git.module.dir.be_._WorkX._Be_assumeModuleDir(child, git))
			//	{
			//		if (
			//			nilnul.fs.git.module.dir_.work.be_._NonTopX._BeNonTop_moduleDirAssumeWork(child, git)
			//		)
			//		{
			//			yield return child;

			//		}
			//	}
			//}
		}

	}
}
