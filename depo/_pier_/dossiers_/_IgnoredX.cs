using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.dossiers_
{
	/// <summary>
	/// staged files, each of which matches a ignore pattern
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _IgnoredX
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
					"ls-files -ic --exclude-standard" //	Standard ignore rules are not automatically activated; therefore, at least one of the --exclude* options is required.

					,
					git
				)
			);
		}
	}
}
