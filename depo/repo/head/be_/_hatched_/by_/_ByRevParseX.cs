using nilnul.os.prog_;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace nilnul.fs.git.depo.repo.head.be_._hatched_.by_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ByRevParseX
	{
		static public bool _Be_0depo(string depo, nilnul.os.prog_.Git git=null) {
			var cod= nilnul.os.prog_.git.run_.exit._CodX._Cod_0address_1argument(
				depo,
				"rev-parse HEAD --"
				,
				git
			);

			if (cod==0)
			{
				return true;
			}
			return false;

			/// for unborn:
			/// cod:128
			/// err:
			///		fatal: bad revision 'HEAD'
			///
			/// for missing head file:
			/// <see cref="_head.file_.xpn_.Dehanced"/>
			/// 
			/// cod:128
			/// err:
			///		fatal: not a git repository (or any of the parent directories): .git
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public static bool _Be_0depo(DirectoryInfo depo, Git git=null)
		{
			return _Be_0depo(depo.FullName,git);
		}
	}

}
