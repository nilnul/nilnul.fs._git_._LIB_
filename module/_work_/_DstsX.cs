using nilnul.fs.address_;
using nilnul.fs.folder_.git_.work_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_
{
	/// <summary>
	/// docs and dirs.
	/// for dirs
	///		not repo;
	///		not submodule
	/// </summary>
	static public class _DstsX
	{

		static public IEnumerable<string> _Addresses_assumeModuleAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Directory.EnumerateFiles(module).Concat(
				_DirsX.Addresses_ofAddress(module,git)
			);
		}
		public static IEnumerable<string> _Addresses_assumeModule(ShieldI en)
		{
			return _Addresses_assumeModuleAddress(en.ToString());
		}

		public static IEnumerable<string> Addresses(Top work)
		{
			return _Addresses_assumeModule(work.en.address.en);
		}

	}
}
