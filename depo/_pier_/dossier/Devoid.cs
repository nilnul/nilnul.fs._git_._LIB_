using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.dossier
{
	/// <summary>
	/// To stage the file for deletion without deleting it from the file system, use
	///		git rm --cached foo
	///	when "foo" is not in stage:
	///		fatal: pathspec 'foo' did not match any files	
	/// </summary>
	/// <remarks>
	/// </remarks>
	///  the file might be still in werk, but marked for removal in coming commit;
	/// 
	/// <see cref="_stow_.dossier.Drop"/>
	/// alias:
	///		devoid
	///		
	internal class Devoid
	{
	}
}
