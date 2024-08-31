using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._repo
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// the index is not part of repo. but it's stored here, or it can be missing;
	/// </remarks>
	static public class _PathX
	{
		static public string DNT = ".git";

		static public string GetSpear(string depo) {
			return System.IO.Path.Combine(depo,DNT);
		}
		static public string GetShield(string depo) {
			return GetSpear(depo) + System.IO.Path.DirectorySeparatorChar;
		}
		static public string GetAddress(string depo) {
			return System.IO.Path.Combine(depo,DNT);
		}


	}
}
