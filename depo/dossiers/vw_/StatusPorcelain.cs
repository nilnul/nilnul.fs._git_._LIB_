using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.dossiers.vw_
{
	/// <summary>
	/// git status --porcelain
	/// ,in result, each entry is listed as:
	///		XY dossier1.ext
	///		XY orig_path -> path
	///		,where X is for stage, Y is for werk
	///		,ORIG_PATH is only shown when the entry is renamed or copied
	///		
	///	eg:
	///	“ M” represents the modified file in the working directory.
	///	“ D” shows the deleted file in the working directory.
	///	“A ” indicates a new file added to the staging index.
	///	“??” displays the untracked file:
	///	R = renamed
	///	T = file type changed (regular file, symbolic link or submodule)
	///	C = copied (if config option status.renames is set to "copies")
	/// U = updated but unmerged
	///
	/// 
	/// ignored files are not shown; (to show that, use --ignored);ignored files are indicated by !!
	/// </summary>
	/// <remarks>
	/// might show directory if all files in that directory share the same status;
	/// </remarks>
	static public class _StatusPorcelainX
	{
		static public IEnumerable<(string mode, string dossier)> _GetModes_0depo(
			string _depo
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return  nilnul.txt.split_._LineX.Line_removeWhite(
				nilnul.os.prog_.git.run_.exit.result._MsgX.OfAddress(
					_depo
					,
					"status --porcelain=v1"

					,
					git
				)
			).Select(
				l => (mode: l.Substring(0, 2), dossier: l.Substring(3))
			);


		}
	}
}
