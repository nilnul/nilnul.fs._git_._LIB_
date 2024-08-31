using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo._head
{
	/// <summary>
	/// HEAD must exist, by definition, in a repository
	/// </summary>
	/// vs:
	///		<see cref="depo._pier.File"/> which can be nonexist;
	static public class _FileX
	{
		static public string DNT = "HEAD";

		static public string _GetSpear_0depo(string depo) {
			return System.IO.Path.Combine(fs.git.depo._repo._PathX.GetAddress(depo),DNT);
		}

		public static string _GetSpear_0depo(System.IO.DirectoryInfo _depo)
		{
			return _GetSpear_0depo(_depo.FullName);
		}
	}
}
