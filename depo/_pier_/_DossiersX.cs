using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_
{
	/// <summary>
	/// git ls-files -c
	///		 --cached
	///		Show all files cached in Git’s index, i.e. all tracked files. (This is the default if no -c/-s/-d/-o/-u/-k/-m/--resolve-undo options are specified.)
	/// </summary>
	/// <remarks>
	/// git ls-files 
	/// 
	/// </remarks>
	/// todo: test whether this would include marked4removal<see cref="dossiers_.IMarked4deletion"/>
	static public class _DossiersX
	{
		static public IEnumerable<string> _GetDossiers_0depo(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo
					,
					"ls-files" // same as:	git ls-files -c
					/// or --cached
					///  it seems, --exclude-standard is appended by default;

					,
					git
				)
			);
		}
	}
}
