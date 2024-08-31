using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.dossier
{
	/// <summary>
	/// Use
	///		git rm foo
	///	,to stage the file for deletion. (This will also delete the file from the file system, if it hadn't been previously deleted.)
	/// </summary>
	/// <remarks>
	/// The files being removed have to be identical to the tip of the branch, and no updates to their contents can be staged in the index, though that default behavior can be overridden with the -f option.
	/// </remarks>
	/// 
	/// <see cref="_pier_.dossier.Devoid"/>
	/// <see cref="_pier_.dossier.drop_.AlsoDropFromWerk"/>
	/// todo:
	///		whence the -f is needed; will the -f would always succeed?
	internal class Drop
	{
	}
}
