using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_
{
	///git-scm.com/docs/git-ls-files
	///This command merges the file listing in the index with the actual working directory list, and shows different combinations of the two.
	///
	/// <summary>
	/// git ls-files --others --cached
	/// # in short:
	/// git ls-files -oc
	/// </summary>
	/// <remarks>
	/// if a file is removed from the werk, but still in the head snapshort, then the file is still listed.
	/// </remarks>
	/// <see cref="fs.git.depo._werk_.dossiers_._IncludedX"/>
	static  class _DossiersX
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
					"ls-files -oc" //	 //seems to include tracked unchanged files;
							/// ignored is still regarded as part of werk;

					,
					git
				)
			);
		}
	}
}
