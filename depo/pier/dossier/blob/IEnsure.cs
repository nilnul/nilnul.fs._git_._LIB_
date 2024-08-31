using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.dossier.blob
{
	/// <summary>
	/// If you have already added the file to the repository, the git add command will simply update the staging area	with the latest version of the file.
	/// </summary>
	/// <remarks>
	/// The main purpose of the index is to hold whatever will go into the next commit.
	/// </remarks>
	///Only the latest version added will be accessible from the index. previous versions eventually get garbage collected.
	/// It contains only one copy of each file, the one you added with the last git add command you ran.

	internal class IEnsure
	{
	}
}
