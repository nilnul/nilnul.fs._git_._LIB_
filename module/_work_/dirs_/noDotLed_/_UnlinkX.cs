using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.dirs_.noDotLed_
{
	/// <summary>
	/// </summary>
	///
	/// <see cref="nilnul.fs.folder_.giT_.work_.nontop.dirs_.notDotLed_.nonlink_._NontopX"/>
	static public class _UnlinkX
	{

		static public IEnumerable<DirectoryInfo> _Infos_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return dirs_._NotDotLedX._DirInfoEs_addressAssumeModule(
				module
				,
				git
			).Where(
				x=>	nilnul.fs.folder.dir.be_.symlink._AntoX._Be_assumeAddressAsParented(
					x.FullName
				)
			);
			
		}
	}
}