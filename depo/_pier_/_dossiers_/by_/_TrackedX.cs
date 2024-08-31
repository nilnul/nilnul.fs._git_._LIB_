using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.destinies_
{
	/// <summary>
	/// git ls-files -c
	///		 --cached
	///		Show all files cached in Git’s index, i.e. all tracked files. (This is the default if no -c/-s/-d/-o/-u/-k/-m/--resolve-undo options are specified.)
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	///
	 [Obsolete(nameof(_pier_._DossiersX))]
	static public class _TrackedX
	{
		static public IEnumerable<string> Get4documents(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.os.prog_.git.run_.exit.result._MsgX.OfAddress(
					depo
					,
					"ls-files -c" //	

					,
					git
				)
			);
		}
	}
}
